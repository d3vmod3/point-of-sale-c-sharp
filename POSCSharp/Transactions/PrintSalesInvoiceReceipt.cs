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
    public class PrintSalesInvoiceReceipt()
    {
        public static void GenerateReceiptFromDatabase(string invoiceNumber)
        {
            //try
            //{
            string connString = PAKOPointOfSale.Program.ConnString;

            // Header fields
            decimal vatAmount = 0m, vatableSales = 0m, vatExempt = 0m, subTotal = 0m, grandTotal = 0m;
            string paymentMethod = "";
            decimal cashReceived = 0m, cashChange = 0m;
            string status = "";

            // Items list: name, qty, unitPrice, total, discount, discountType, uom
            var items = new List<(string productName, string productCode, decimal qty, decimal unitPrice, decimal total, decimal discount, string discountType, string uom)>();

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                // 1) Read transaction header
                using (var cmd = new SqlCommand(@"
                        SELECT id, vat_amount, vatable_sales, vat_exempt, sub_total, grand_total,
                               payment_method, cash_received, cash_change, status
                        FROM Transactions
                        WHERE invoice_number = @invoiceNumber AND status = 'Success'", conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            // Use DBNull checks
                            vatAmount = r.IsDBNull(r.GetOrdinal("vat_amount")) ? 0m : Convert.ToDecimal(r["vat_amount"]);
                            vatableSales = r.IsDBNull(r.GetOrdinal("vatable_sales")) ? 0m : Convert.ToDecimal(r["vatable_sales"]);
                            vatExempt = r.IsDBNull(r.GetOrdinal("vat_exempt")) ? 0m : Convert.ToDecimal(r["vat_exempt"]);
                            subTotal = r.IsDBNull(r.GetOrdinal("sub_total")) ? 0m : Convert.ToDecimal(r["sub_total"]);
                            grandTotal = r.IsDBNull(r.GetOrdinal("grand_total")) ? 0m : Convert.ToDecimal(r["grand_total"]);
                            paymentMethod = r.IsDBNull(r.GetOrdinal("payment_method")) ? "" : r["payment_method"].ToString();
                            cashReceived = r.IsDBNull(r.GetOrdinal("cash_received")) ? 0m : Convert.ToDecimal(r["cash_received"]);
                            cashChange = r.IsDBNull(r.GetOrdinal("cash_change")) ? 0m : Convert.ToDecimal(r["cash_change"]);
                            status = r.IsDBNull(r.GetOrdinal("status")) ? "" : r["status"].ToString();
                        }
                        else
                        {
                            MessageBox.Show($"No successful transaction found for invoice: {invoiceNumber}",
                                "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                // 2) Read sales invoice items and their discount fields (from SalesInvoiceItems)
                using (var cmd = new SqlCommand(@"
                        SELECT p.product_name, p.product_code, si.quantity, si.unit_price, si.total_amount, si.discount, si.discount_type, si.unit_of_measurement
                        FROM SalesInvoiceItems si
                        INNER JOIN Products p ON si.product_id = p.id
                        INNER JOIN Transactions t ON si.transaction_id = t.id
                        WHERE t.invoice_number = @invoiceNumber
                        ORDER BY si.id", conn))
                {
                    cmd.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string productName = r.IsDBNull(r.GetOrdinal("product_name")) ? "" : r["product_name"].ToString();
                            string productCode = r.IsDBNull(r.GetOrdinal("product_code")) ? "" : r["product_code"].ToString();
                            decimal qty = r.IsDBNull(r.GetOrdinal("quantity")) ? 0m : Convert.ToDecimal(r["quantity"]);
                            decimal unitPrice = r.IsDBNull(r.GetOrdinal("unit_price")) ? 0m : Convert.ToDecimal(r["unit_price"]);
                            decimal total = r.IsDBNull(r.GetOrdinal("total_amount")) ? 0m : Convert.ToDecimal(r["total_amount"]);
                            decimal discount = r.IsDBNull(r.GetOrdinal("discount")) ? 0m : Convert.ToDecimal(r["discount"]);
                            string discountType = r.IsDBNull(r.GetOrdinal("discount_type")) ? "" : r["discount_type"].ToString();
                            string uom = r.IsDBNull(r.GetOrdinal("unit_of_measurement")) ? "" : r["unit_of_measurement"].ToString();

                            items.Add((productName, productCode, qty, unitPrice, total, discount, discountType, uom));

                        }
                    }
                }
            } // end using conn

            // Generate PDF
            SaveAsPdf(invoiceNumber, items, vatAmount, vatableSales, vatExempt, subTotal, grandTotal,
                paymentMethod, cashReceived, cashChange);
        }
        //catch (Exception ex)
        //{
        //MessageBox.Show("Error generating receipt: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        private string N2(object value)
        {
            return Convert.ToDecimal(value).ToString("N2");
        }



        private static void SaveAsPdf(
            string invoiceNumber,
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
                string safeInvoiceNumber = string.Join(
                    "_", invoiceNumber.Split(Path.GetInvalidFileNameChars()));

                string pdfPath = Path.Combine(
                    appPath, $"Receipt_{safeInvoiceNumber}.pdf");

                const double receiptWidth = 80 * 72.0 / 25.4;
                const double margin = 14;
                const double lineHeight = 12;

                double contentWidth = receiptWidth - margin * 2;

                using var doc = new PdfDocument();
                var page = doc.AddPage();

                page.Width = XUnit.FromMillimeter(80);

                // Temporary height. Adjust to the actual content after drawing.
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

                    // Drawing helpers
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

                    // Wrap product names according to their actual rendered width.
                    void DrawWrappedText(
                        string text, XFont font, double x,
                        double top, double maxWidth, double height)
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
                                        line, font, x, top,
                                        maxWidth);

                                    top += height;
                                }

                                // Split exceptionally long words if necessary.
                                line = "";

                                foreach (char ch in word)
                                {
                                    string next = line + ch;

                                    if (line.Length > 0 &&
                                        gfx.MeasureString(next, font).Width
                                        > maxWidth)
                                    {
                                        DrawText(
                                            line, font, x, top,
                                            maxWidth);

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

                    //Center(
                    //    "MOTORCYCLE PARTS & ACCESSORIES",
                    //    smallFont, y);
                    //y += 15;

                    Separator(y);
                    y += 9;

                    Center("SALES INVOICE", titleFont, y);
                    y += 17;

                    DrawPair("Invoice No.:", invoiceNumber);
                    DrawPair(
                        "Date:",
                        DateTime.Now.ToString("MMM dd, yyyy HH:mm"));

                    y += 4;
                    Separator(y);
                    y += 10;

                    // ITEMS HEADER
                    DrawText(
                        "ITEM", boldFont,
                        margin, y, contentWidth);

                    y += 15;

                    DrawText(
                        "QTY", boldFont,
                        margin, y, 48);

                    DrawText(
                        "PRICE", boldFont,
                        margin + 85, y, 65);

                    DrawText(
                        "AMOUNT", boldFont,
                        margin, y, contentWidth,
                        XStringAlignment.Far);

                    y += 10;
                    Separator(y);
                    y += 9;

                    // ITEM DETAILS
                    foreach (var it in items)
                    {
                        // Prefer the product name. Use product code only
                        // when a name is unavailable.
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

                        // Quantity, unit price, and line total.
                        DrawText(
                            $"{it.qty:N2} {it.uom}",
                            smallFont,
                            margin, y, 48);

                        DrawText(
                            $"₱{it.unitPrice:N2}",
                            smallFont,
                            margin + 85, y, 65);

                        DrawText(
                            $"₱{it.total:N2}",
                            smallFont,
                            margin, y, contentWidth,
                            XStringAlignment.Far);

                        y += lineHeight + 3;

                        // Discount details
                        if (!string.IsNullOrWhiteSpace(it.discountType) &&
                            !it.discountType.Equals(
                                "none",
                                StringComparison.OrdinalIgnoreCase) &&
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

                    // TOTALS
                    Separator(y);
                    y += 12;

                    DrawPair("Subtotal", $"₱{subTotal:N2}");
                    DrawPair("VATable Sales", $"₱{vatableSales:N2}");
                    DrawPair("VAT Amount (12%)", $"₱{vatAmount:N2}");
                    DrawPair("VAT Exempt Sales", $"₱{vatExempt:N2}");

                    y += 4;
                    Separator(y);
                    y += 12;

                    // Emphasized grand total
                    DrawText(
                        "GRAND TOTAL",
                        titleFont,
                        margin, y, contentWidth);

                    y += 17;

                    DrawText(
                        $"₱{grandTotal:N2}",
                        totalFont,
                        margin, y, contentWidth,
                        XStringAlignment.Far);

                    y += 22;
                    Separator(y);
                    y += 12;

                    // PAYMENT
                    DrawPair("Payment Method", paymentMethod);
                    DrawPair("Cash Received", $"₱{cashReceived:N2}");
                    DrawPair("Change", $"₱{cashChange:N2}");

                    y += 7;
                    Separator(y);
                    y += 15;

                    // FOOTER
                    Center("THANK YOU FOR YOUR PURCHASE!", boldFont, y);
                    y += 15;

                    Center(
                        "Please keep your receipt for reference.",
                        smallFont, y);
                    y += 14;

                    Center(
                        "TUZON VARIETY STORE",
                        smallFont, y);

                    y += 18;

                    // Set page height to the actual content height.
                    //page.Height = XUnit.FromPoint(y);
                }

                doc.Save(pdfPath);


                // Open using the default PDF viewer.
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
                    "Error saving PDF: " + ex.Message,
                    "PDF Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
