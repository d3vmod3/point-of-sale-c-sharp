using Microsoft.Data.SqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAKOPointOfSale.Transactions
{
    public class PrintVoidReceipt
    {
        public static void GenerateVoidReceiptFromTransactionId(int transactionId)
        {
            try
            {
                string connString = PAKOPointOfSale.Program.ConnString;

                // Header fields
                string voidNumber = "";
                decimal vatAmount = 0m, vatableSales = 0m, vatExempt = 0m, subTotal = 0m, grandTotal = 0m;
                string paymentMethod = "";
                decimal cashReceived = 0m, cashChange = 0m;
                string status = "";
                string invoiceNumber = "";

                var items = new List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)>();

                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // ✅ 1) Get void number from VoidTransactions
                    using (var cmd = new SqlCommand(@"
                        SELECT TOP 1 void_number
                        FROM VoidTransactions
                        WHERE transaction_id = @transactionId", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                            voidNumber = result.ToString();
                        else
                            voidNumber = "N/A";
                    }

                    // 2) Read transaction header
                    using (var cmd = new SqlCommand(@"
                        SELECT id, invoice_number, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total,
                               payment_method, cash_received, cash_change, status
                        FROM Transactions
                        WHERE id = @transactionId AND transaction_type = 'void'", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        using (var r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                invoiceNumber = r["invoice_number"].ToString();
                                vatAmount = Convert.ToDecimal(r["vat_amount"]);
                                vatableSales = Convert.ToDecimal(r["vatable_sales"]);
                                vatExempt = Convert.ToDecimal(r["vat_exempt"]);
                                subTotal = Convert.ToDecimal(r["sub_total"]);
                                grandTotal = Convert.ToDecimal(r["grand_total"]);
                                paymentMethod = r["payment_method"].ToString();
                                cashReceived = Convert.ToDecimal(r["cash_received"]);
                                cashChange = Convert.ToDecimal(r["cash_change"]);
                                status = r["status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show($"No void transaction found for Transaction ID: {transactionId}",
                                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // 3) Read items
                    using (var cmd = new SqlCommand(@"
                        SELECT p.product_name, p.product_code, si.quantity, si.unit_price, si.total_amount, 
                               si.discount, si.discount_type, si.unit_of_measurement
                        FROM SalesInvoiceItems si
                        INNER JOIN Products p ON si.product_id = p.id
                        WHERE si.transaction_id = @transactionId
                        ORDER BY si.id", conn))
                    {
                        cmd.Parameters.AddWithValue("@transactionId", transactionId);
                        using (var r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                items.Add((
                                    r["product_name"].ToString(),
                                    r["product_code"].ToString(),
                                    Convert.ToDecimal(r["quantity"]),
                                    Convert.ToDecimal(r["unit_price"]),
                                    Convert.ToDecimal(r["total_amount"]),
                                    Convert.ToDecimal(r["discount"]),
                                    r["discount_type"].ToString(),
                                    r["unit_of_measurement"].ToString()
                                ));
                            }
                        }
                    }
                }

                // ✅ Pass voidNumber to the PDF
                SaveAsPdf(invoiceNumber, voidNumber, items, vatAmount, vatableSales, vatExempt, subTotal, grandTotal,
                    paymentMethod, cashReceived, cashChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating void receipt: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ⬇ Updated SaveAsPdf() to include voidNumber parameter

        private static void SaveAsPdf(
            string invoiceNumber,
            string voidNumber,
            List<(string productName, string productCode, decimal qty,
                decimal unitPrice, decimal total, decimal discount,
                string discountType, string uom)> items,
            decimal vatAmount, decimal vatableSales, decimal vatExempt,
            decimal subTotal, decimal grandTotal,
            string paymentMethod, decimal cashReceived, decimal cashChange)
        {
            try
            {
                string appPath = Application.StartupPath;

                string safeVoidNumber = string.Join(
                    "_", voidNumber.Split(Path.GetInvalidFileNameChars()));

                string pdfPath = Path.Combine(
                    appPath, $"Void_{safeVoidNumber}.pdf");

                const double receiptWidth = 80 * 72.0 / 25.4;
                const double margin = 14;
                const double lineHeight = 12;

                double contentWidth = receiptWidth - margin * 2;

                using var doc = new PdfDocument();
                var page = doc.AddPage();

                page.Width = XUnit.FromMillimeter(80);
                page.Height = XUnit.FromPoint(2000);

                using (var gfx = XGraphics.FromPdfPage(page))
                {
                    var storeFont = new XFont(
                        "Arial", 14, XFontStyle.Bold);

                    var titleFont = new XFont(
                        "Arial", 10, XFontStyle.Bold);

                    var boldFont = new XFont(
                        "Arial", 8, XFontStyle.Bold);

                    var regularFont = new XFont(
                        "Arial", 8, XFontStyle.Regular);

                    var smallFont = new XFont(
                        "Arial", 7, XFontStyle.Regular);

                    var totalFont = new XFont(
                        "Arial", 12, XFontStyle.Bold);

                    var grayBrush = new XSolidBrush(
                        XColor.FromArgb(90, 90, 90));

                    var separatorPen = new XPen(
                        XColor.FromArgb(100, 100, 100), 0.6);

                    double y = 14;

                    void DrawText(
                        string text, XFont font,
                        double x, double top, double width,
                        XStringAlignment alignment = XStringAlignment.Near,
                        XBrush brush = null)
                    {
                        var format = new XStringFormat
                        {
                            Alignment = alignment,
                            LineAlignment = XLineAlignment.Near
                        };

                        gfx.DrawString(
                            text,
                            font,
                            brush ?? XBrushes.Black,
                            new XRect(x, top, width, 18),
                            format);
                    }

                    void Center(string text, XFont font, double top)
                    {
                        DrawText(
                            text, font, 0, top,
                            receiptWidth, XStringAlignment.Center);
                    }

                    void Separator(double top)
                    {
                        gfx.DrawLine(
                            separatorPen,
                            margin, top,
                            receiptWidth - margin, top);
                    }

                    void DrawPair(
                        string label, string value,
                        XFont font = null)
                    {
                        font ??= regularFont;

                        DrawText(label, font, margin, y, contentWidth);

                        DrawText(
                            value, font, margin, y,
                            contentWidth, XStringAlignment.Far);

                        y += lineHeight;
                    }

                    void DrawWrappedText(
                        string text, XFont font,
                        double x, double top,
                        double maxWidth, double height)
                    {
                        if (string.IsNullOrWhiteSpace(text))
                        {
                            y += height;
                            return;
                        }

                        string[] words = text.Split(
                            new[] { ' ', '\t', '\r', '\n' },
                            StringSplitOptions.RemoveEmptyEntries);

                        string line = "";

                        foreach (string word in words)
                        {
                            string candidate = string.IsNullOrEmpty(line)
                                ? word
                                : line + " " + word;

                            if (gfx.MeasureString(candidate, font).Width
                                <= maxWidth)
                            {
                                line = candidate;
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(line))
                                {
                                    DrawText(
                                        line, font, x, top, maxWidth);

                                    top += height;
                                }

                                line = "";

                                // Split unusually long words when necessary.
                                foreach (char ch in word)
                                {
                                    string next = line + ch;

                                    if (line.Length > 0 &&
                                        gfx.MeasureString(next, font).Width
                                        > maxWidth)
                                    {
                                        DrawText(
                                            line, font, x, top, maxWidth);

                                        top += height;
                                        line = ch.ToString();
                                    }
                                    else
                                    {
                                        line = next;
                                    }
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(line))
                        {
                            DrawText(line, font, x, top, maxWidth);
                            top += height;
                        }

                        y = top;
                    }

                    // HEADER
                    Center("TUZON VARIETY STORE", storeFont, y);
                    y += 20;

                    Separator(y);
                    y += 9;

                    Center("VOID", titleFont, y);
                    y += 17;

                    DrawPair("Void No.:", voidNumber);
                    DrawPair("Original Invoice:", invoiceNumber);

                    DrawPair(
                        "Date:",
                        DateTime.Now.ToString("MMM dd, yyyy HH:mm"));

                    y += 4;
                    Separator(y);
                    y += 10;

                    // ITEMS HEADER
                    DrawText(
                        "ITEMS",
                        boldFont, margin, y, contentWidth);

                    y += 15;

                    DrawText(
                        "QTY", boldFont, margin, y, 48);

                    DrawText(
                        "PRICE", boldFont, margin + 85, y, 65);

                    DrawText(
                        "AMOUNT", boldFont, margin, y,
                        contentWidth, XStringAlignment.Far);

                    y += 10;
                    Separator(y);
                    y += 9;

                    // VOIDED ITEMS
                    foreach (var it in items)
                    {
                        string productName =
                            string.IsNullOrWhiteSpace(it.productCode)
                                ? it.productName
                                : it.productCode;

                        DrawWrappedText(
                            productName,
                            boldFont,
                            margin,
                            y,
                            contentWidth,
                            lineHeight);

                        DrawText(
                            $"{it.qty:N2} {it.uom}",
                            smallFont, margin, y, 48);

                        DrawText(
                            $"₱{it.unitPrice:N2}",
                            smallFont, margin + 85, y, 65);

                        DrawText(
                            $"-₱{it.total:N2}",
                            smallFont, margin, y,
                            contentWidth, XStringAlignment.Far);

                        y += lineHeight + 3;

                        if (!string.IsNullOrWhiteSpace(it.discountType) &&
                            !it.discountType.Equals(
                                "none", StringComparison.OrdinalIgnoreCase) &&
                            it.discount > 0)
                        {
                            DrawText(
                                $"Discount ({it.discountType}): " +
                                $"-₱{it.discount:N2}",
                                smallFont,
                                margin + 4, y, contentWidth - 4,
                                XStringAlignment.Near,
                                grayBrush);

                            y += lineHeight;
                        }

                        y += 3;
                    }

                    // VOID TOTALS
                    Separator(y);
                    y += 12;

                    DrawPair("Subtotal", $"-₱{subTotal:N2}");
                    DrawPair("VATable Sales", $"-₱{vatableSales:N2}");
                    DrawPair("VAT Amount (12%)", $"-₱{vatAmount:N2}");
                    DrawPair("VAT Exempt Sales", $"-₱{vatExempt:N2}");

                    y += 4;
                    Separator(y);
                    y += 12;

                    DrawText(
                        "VOIDED TOTAL",
                        titleFont, margin, y, contentWidth);

                    y += 17;

                    DrawText(
                        $"-₱{grandTotal:N2}",
                        totalFont, margin, y,
                        contentWidth, XStringAlignment.Far);

                    y += 22;
                    Separator(y);
                    y += 12;

                    // PAYMENT DETAILS
                    DrawPair("Payment Method", paymentMethod);
                    DrawPair("Cash Received", $"-₱{cashReceived:N2}");
                    DrawPair("Change", $"-₱{cashChange:N2}");

                    y += 7;
                    Separator(y);
                    y += 15;

                    // FOOTER AND DISCLAIMER
                    Center("TRANSACTION VOIDED", boldFont, y);
                    y += 16;

                    Center(
                        "THIS DOCUMENT IS NOT VALID FOR",
                        smallFont, y);
                    y += 11;

                    Center(
                        "CLAIM OF INPUT TAX",
                        smallFont, y);
                    y += 17;

                    Center(
                        "TUZON VARIETY STORE",
                        smallFont, y);

                    y += 18;
                }

                doc.Save(pdfPath);

                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = pdfPath,
                        UseShellExecute = true
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving void PDF: " + ex.Message,
                    "PDF Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
