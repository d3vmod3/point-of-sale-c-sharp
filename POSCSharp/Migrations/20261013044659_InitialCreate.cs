using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POSCSharp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    module = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payload = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ParkedTransactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    park_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transaction_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedTransactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplier_id = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    product_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    product_brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    product_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barcode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    product_code = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    sku = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    low_stock_quantity = table.Column<int>(type: "int", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_received = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnTransactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    return_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    invoice_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnTransactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VoidTransactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    void_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    invoice_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transaction_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoidTransactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    return_transaction_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vatable_sales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_exempt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    transaction_type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_ReturnItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnItems_ReturnTransactions_return_transaction_id",
                        column: x => x.return_transaction_id,
                        principalTable: "ReturnTransactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_type_id = table.Column<int>(type: "int", nullable: false),
                    module_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    can_view = table.Column<bool>(type: "bit", nullable: false),
                    can_add = table.Column<bool>(type: "bit", nullable: false),
                    can_edit = table.Column<bool>(type: "bit", nullable: false),
                    can_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Permissions_UserTypes_user_type_id",
                        column: x => x.user_type_id,
                        principalTable: "UserTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_type_id = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    middle_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    suffix = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    is_reset = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_user_type_id",
                        column: x => x.user_type_id,
                        principalTable: "UserTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoice_number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    park_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vat_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vatable_sales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_exempt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    sub_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    grand_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    payment_method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cash_received = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cash_change = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParkedTransactionid = table.Column<int>(type: "int", nullable: true),
                    ReturnTransactionid = table.Column<int>(type: "int", nullable: true),
                    VoidTransactionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Transactions_ParkedTransactions_ParkedTransactionid",
                        column: x => x.ParkedTransactionid,
                        principalTable: "ParkedTransactions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Transactions_ReturnTransactions_ReturnTransactionid",
                        column: x => x.ReturnTransactionid,
                        principalTable: "ReturnTransactions",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Transactions_VoidTransactions_VoidTransactionid",
                        column: x => x.VoidTransactionid,
                        principalTable: "VoidTransactions",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ParkedSalesInvoiceItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vatable_sales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_exempt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    transaction_type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkedSalesInvoiceItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParkedSalesInvoiceItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkedSalesInvoiceItems_Transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "Transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vatable_sales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    vat_exempt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    unit_of_measurement = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    transaction_type = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceItems_Products_product_id",
                        column: x => x.product_id,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceItems_Transactions_transaction_id",
                        column: x => x.transaction_id,
                        principalTable: "Transactions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Engine oils, brake fluids, and coolant products", "Lubricants & Fluids" },
                    { 2, "Motorcycle batteries, bulbs, spark plugs, and wiring components", "Electrical & Batteries" },
                    { 3, "Inner tubes, tires, and wheel accessories", "Tires & Wheels" },
                    { 4, "Helmets, gloves, jackets, and safety equipment", "Riding Gear" },
                    { 5, "Brake pads, discs, shocks, and fork oils", "Brakes & Suspension" },
                    { 6, "Drive chains, sprockets, and chain kits", "Chains & Sprockets" },
                    { 7, "Side mirrors, stickers, covers, and guards", "Body & Accessories" },
                    { 8, "Wrenches, lubricants, and cleaning kits", "Tools & Maintenance" },
                    { 9, "Headlights, signal lights, and LED kits", "Lights & Indicators" },
                    { 10, "Pistons, gaskets, valves, and rebuild kits", "Engine Parts" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "id", "key", "updated_at", "value" },
                values: new object[] { 1, "backup_database_location", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "barcode", "category_id", "cost_price", "created_at", "date_expiration", "date_received", "is_active", "low_stock_quantity", "product_brand", "product_code", "product_description", "product_name", "quantity", "remarks", "sku", "status", "supplier_id", "unit_of_measurement", "unit_price" },
                values: new object[,]
                {
                    { 1, "4801981100001", 1, 250m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "Shell Advance", "MO1L", "Engine oil for 4-stroke motorcycles", "Motor Oil 1L", 80, "Best seller", "MO-1L-001", "Good", 1, "Bottle", 300m },
                    { 2, "4801981100001", 1, 80m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "NGK", "SPCR7", "Standard spark plug for small motorcycles", "Spark Plug CR7HSA", 150, "Popular maintenance item", "SP-CR7-002", "Good", 2, "Piece", 120m },
                    { 3, "4801981100002", 2, 950m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "Motolite", "BAT12V5", "Maintenance-free motorcycle battery", "Motorcycle Battery 12V 5Ah", 40, "Long-lasting battery", "BAT-12V5-003", "Good", 3, "Piece", 1200m },
                    { 4, "4801981100002", 2, 800m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 15, "RK Takasago", "CHAINKIT", "Durable chain and sprocket set", "Motorcycle Chain Kit", 30, "High-quality drive kit", "CHN-KT-004", "Good", 4, "Set", 950m },
                    { 5, "4801981100002", 3, 950m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "IRC", "TIRE17", "Tubeless motorcycle tire", "Motorcycle Tire 17x2.50", 50, "Durable rubber tire", "TIR-17-005", "Good", 5, "Piece", 1200m },
                    { 6, "4801981100006", 3, 1400m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 5, "LS2", "HLMFF", "DOT-approved full-face helmet", "Motorcycle Helmet Full Face", 20, "Safety equipment", "HLM-FF-006", "Good", 6, "Piece", 1800m },
                    { 7, "4801981100007", 4, 350m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "Alpinestars", "GLV001", "Riding gloves with knuckle protection", "Motorcycle Gloves", 60, "Comfortable fit", "GLV-001-007", "Good", 7, "Pair", 500m },
                    { 8, "4801981100008", 4, 250m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10, "Racing Boy", "MIRSET", "Adjustable aluminum side mirrors", "Motorcycle Side Mirror Set", 45, "Chrome finish", "MIR-SET-008", "Good", 8, "Set", 400m },
                    { 9, "4801981100009", 5, 90m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "Bosch", "BLBH4", "High-brightness headlight bulb", "Motorcycle Headlight Bulb H4", 50, "12V 35/35W", "BLB-H4-009", "Good", 9, "Piece", 150m },
                    { 10, "4801981100010", 5, 600m, new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2030, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 20, "Brembo", "BRKPADS", "High-quality front brake pads", "Motorcycle Brake Pads Front", 50, "Fits most underbone models", "BRK-FR-010", "Good", 10, "Set", 850m }
                });

            migrationBuilder.InsertData(
                table: "SupplierDetails",
                columns: new[] { "id", "address", "contact_number", "created_at", "email", "is_active", "name" },
                values: new object[,]
                {
                    { 1, "123 Street A", "09170000001", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample1@example.com", false, "ABC Traders" },
                    { 2, "456 Street B", "09170000002", new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample10@example.com", false, "XYZ Supplies" },
                    { 3, "789 Street C", "09170000003", new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample2@example.com", false, "MegaCorp" },
                    { 4, "101 Street D", "09170000004", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample3@example.com", false, "Foodies Inc" },
                    { 5, "202 Street E", "09170000005", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample4@example.com", false, "SnackKing" },
                    { 6, "303 Street F", "09170000006", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample5@example.com", false, "ElectroMart" },
                    { 7, "404 Street G", "09170000007", new DateTime(2025, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample6@example.com", false, "Cool Drinks Co" },
                    { 8, "505 Street H", "09170000008", new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample7@example.com", false, "Fresh Foods" },
                    { 9, "606 Street I", "09170000009", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample8@example.com", false, "Global Traders" },
                    { 10, "707 Street J", "09170000010", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "sample9@example.com", false, "Local Supplies" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 2, "Admin" },
                    { 3, "Cashier" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "id", "can_add", "can_delete", "can_edit", "can_view", "module_name", "user_type_id" },
                values: new object[,]
                {
                    { 8, true, true, true, true, "Categories", 2 },
                    { 9, true, true, true, true, "Products", 2 },
                    { 10, true, true, true, true, "Suppliers", 2 },
                    { 11, true, false, false, true, "Sales Invoice", 2 },
                    { 12, false, false, false, true, "Transactions", 2 },
                    { 13, false, false, true, true, "User Access Control", 2 },
                    { 14, true, true, true, true, "Users", 2 },
                    { 15, false, false, false, false, "Categories", 3 },
                    { 16, false, false, false, false, "Products", 3 },
                    { 17, false, false, false, false, "Suppliers", 3 },
                    { 18, true, false, true, true, "Sales Invoice", 3 },
                    { 19, false, false, true, true, "Transactions", 3 },
                    { 20, false, false, false, false, "User Access Control", 3 },
                    { 21, false, false, false, false, "Users", 3 },
                    { 22, false, false, false, true, "Top 5 Selling", 2 },
                    { 23, false, false, false, true, "Low in Stock", 2 },
                    { 24, false, false, false, true, "Sales", 2 },
                    { 25, false, false, false, true, "Dashboard", 2 },
                    { 26, false, false, false, false, "Top 5 Selling", 3 },
                    { 27, false, false, false, true, "Low in Stock", 3 },
                    { 28, false, false, false, false, "Sales", 3 },
                    { 29, false, false, false, false, "Dashboard", 3 },
                    { 30, false, false, false, true, "Options", 2 },
                    { 31, false, false, false, true, "Activity Logs", 2 },
                    { 32, false, false, true, true, "Backup Database", 2 },
                    { 33, false, false, false, false, "Options", 3 },
                    { 34, false, false, false, false, "Activity Logs", 3 },
                    { 35, false, false, false, false, "Backup Database", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "birthday", "created_at", "first_name", "gender", "is_active", "is_reset", "last_name", "middle_name", "password", "suffix", "user_type_id", "username" },
                values: new object[,]
                {
                    { 2, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Christy", "Female", true, false, "Anguluan", null, "password123", null, 2, "admin" },
                    { 3, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 10, 14, 10, 0, 0, 0, DateTimeKind.Unspecified), "Bryan", "Male", true, false, "Mabborang", null, "password123", null, 3, "cashier" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkedSalesInvoiceItems_product_id",
                table: "ParkedSalesInvoiceItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ParkedSalesInvoiceItems_transaction_id",
                table: "ParkedSalesInvoiceItems",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_user_type_id",
                table: "Permissions",
                column: "user_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_product_id",
                table: "ReturnItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnItems_return_transaction_id",
                table: "ReturnItems",
                column: "return_transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceItems_product_id",
                table: "SalesInvoiceItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceItems_transaction_id",
                table: "SalesInvoiceItems",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ParkedTransactionid",
                table: "Transactions",
                column: "ParkedTransactionid");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ReturnTransactionid",
                table: "Transactions",
                column: "ReturnTransactionid");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_VoidTransactionid",
                table: "Transactions",
                column: "VoidTransactionid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_user_type_id",
                table: "Users",
                column: "user_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "ParkedSalesInvoiceItems");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ReturnItems");

            migrationBuilder.DropTable(
                name: "SalesInvoiceItems");

            migrationBuilder.DropTable(
                name: "SupplierDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "ParkedTransactions");

            migrationBuilder.DropTable(
                name: "ReturnTransactions");

            migrationBuilder.DropTable(
                name: "VoidTransactions");
        }
    }
}
