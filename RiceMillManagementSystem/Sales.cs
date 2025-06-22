using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace RiceMillManagementSystem
{
    public partial class Sales : Form
    {
        private readonly string connectionString = "Data Source=Afridi;Initial Catalog=ricemillmanagement;Integrated Security=True;TrustServerCertificate=True";
        private readonly int userId;
        private Dictionary<string, string> saleToPrint = new Dictionary<string, string>();

        public Sales(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadUserData();
            PopulateComboBoxes();
            PopulateSalesGrid();
            GenerateInvoiceNumber();
            btnSales.Enabled = false;
        }

        private void LoadUserData()
        {
            // Add code to load user's name, same as other forms
        }

        private void PopulateComboBoxes()
        {
            PopulateComboBox(cmbCustomers, "SELECT CustomerID, Name FROM Customers", "Name", "CustomerID");
            PopulateComboBox(cmbItems, "SELECT ItemID, ItemName FROM Inventory WHERE Quantity > 0", "ItemName", "ItemID");
        }

        private void PopulateComboBox(ComboBox cmb, string query, string displayMember, string valueMember)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmb.DataSource = dt;
                    cmb.DisplayMember = displayMember;
                    cmb.ValueMember = valueMember;
                    cmb.SelectedIndex = -1; // No default selection
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error populating dropdown: " + ex.Message);
                }
            }
        }

        private void PopulateSalesGrid()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"SELECT s.SaleID, s.InvoiceNumber, c.Name AS Customer, i.ItemName, s.Quantity, s.UnitPrice, s.TotalAmount, s.SaleDate 
                                   FROM Sales s
                                   JOIN Customers c ON s.CustomerID = c.CustomerID
                                   JOIN Inventory i ON s.ItemID = i.ItemID
                                   ORDER BY s.SaleDate DESC";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvSales.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading sales history: " + ex.Message);
                }
            }
        }

        private void GenerateInvoiceNumber()
        {
            lblInvoiceNumber.Text = "INV-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItems.SelectedValue == null)
            {
                lblStockAvailable.Text = "0";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Quantity FROM Inventory WHERE ItemID = @ItemID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemID", cmbItems.SelectedValue);
                    object result = cmd.ExecuteScalar();
                    lblStockAvailable.Text = result?.ToString() ?? "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching stock: " + ex.Message);
                }
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            decimal.TryParse(txtQuantity.Text, out decimal quantity);
            decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice);
            lblTotalAmount.Text = (quantity * unitPrice).ToString("0.00");
        }

        private void btnRecordSale_Click(object sender, EventArgs e)
        {
            // --- Validations ---
            if (cmbCustomers.SelectedValue == null || cmbItems.SelectedValue == null) { MessageBox.Show("Please select a customer and an item."); return; }
            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0) { MessageBox.Show("Please enter a valid quantity."); return; }
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0) { MessageBox.Show("Please enter a valid unit price."); return; }
            if (!decimal.TryParse(lblStockAvailable.Text, out decimal availableStock) || quantity > availableStock) { MessageBox.Show("Cannot sell. Quantity exceeds available stock."); return; }

            // --- Database Transaction ---
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Update Inventory (with stock check)
                    string inventoryQuery = "UPDATE Inventory SET Quantity = Quantity - @SaleQuantity, LastUpdated = GETDATE() WHERE ItemID = @ItemID AND Quantity >= @SaleQuantity";
                    SqlCommand inventoryCmd = new SqlCommand(inventoryQuery, conn, transaction);
                    inventoryCmd.Parameters.AddWithValue("@SaleQuantity", quantity);
                    inventoryCmd.Parameters.AddWithValue("@ItemID", cmbItems.SelectedValue);
                    int rowsAffected = inventoryCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        // This means stock was insufficient.
                        throw new Exception("Inventory update failed. Insufficient stock or item not found.");
                    }

                    // 2. Insert into Sales table
                    string saleQuery = "INSERT INTO Sales (CustomerID, ItemID, Quantity, UnitPrice, TotalAmount, SaleDate, InvoiceNumber) VALUES (@CustomerID, @ItemID, @Quantity, @UnitPrice, @TotalAmount, @SaleDate, @InvoiceNumber)";
                    SqlCommand saleCmd = new SqlCommand(saleQuery, conn, transaction);
                    saleCmd.Parameters.AddWithValue("@CustomerID", cmbCustomers.SelectedValue);
                    saleCmd.Parameters.AddWithValue("@ItemID", cmbItems.SelectedValue);
                    saleCmd.Parameters.AddWithValue("@Quantity", quantity);
                    saleCmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    saleCmd.Parameters.AddWithValue("@TotalAmount", quantity * unitPrice);
                    saleCmd.Parameters.AddWithValue("@SaleDate", dtpSaleDate.Value);
                    saleCmd.Parameters.AddWithValue("@InvoiceNumber", lblInvoiceNumber.Text);
                    saleCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Sale recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Sale failed. Transaction rolled back. Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Refresh and reset
            PopulateSalesGrid();
            PopulateComboBoxes(); // Re-populate to update stock availability
            ClearForm();
            GenerateInvoiceNumber();
        }

        private void ClearForm()
        {
            cmbCustomers.SelectedIndex = -1;
            cmbItems.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            lblTotalAmount.Text = "0.00";
            lblStockAvailable.Text = "0";
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnPrintInvoice.Enabled = true;
                DataGridViewRow row = dgvSales.Rows[e.RowIndex];

                // Store details for printing
                saleToPrint["InvoiceNumber"] = row.Cells["InvoiceNumber"].Value.ToString();
                saleToPrint["SaleDate"] = Convert.ToDateTime(row.Cells["SaleDate"].Value).ToLongDateString();
                saleToPrint["Customer"] = row.Cells["Customer"].Value.ToString();
                saleToPrint["ItemName"] = row.Cells["ItemName"].Value.ToString();
                saleToPrint["Quantity"] = row.Cells["Quantity"].Value.ToString();
                saleToPrint["UnitPrice"] = Convert.ToDecimal(row.Cells["UnitPrice"].Value).ToString("C");
                saleToPrint["TotalAmount"] = Convert.ToDecimal(row.Cells["TotalAmount"].Value).ToString("C");
            }
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (saleToPrint.Count > 0)
            {
                PrintPreviewDialog printPreview = new PrintPreviewDialog();
                printPreview.Document = printDocument1;
                printPreview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a sale from the history to print.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);
            float yPos = 50;
            int startX = 50;
            int offset = 30;

            g.DrawString("SALE INVOICE", titleFont, Brushes.Black, startX, yPos);
            yPos += offset * 2;

            g.DrawString("Invoice #: " + saleToPrint["InvoiceNumber"], bodyFont, Brushes.Black, startX, yPos);
            yPos += offset;
            g.DrawString("Date: " + saleToPrint["SaleDate"], bodyFont, Brushes.Black, startX, yPos);
            yPos += offset * 2;

            g.DrawString("Customer: " + saleToPrint["Customer"], headerFont, Brushes.Black, startX, yPos);
            yPos += offset * 2;

            g.DrawString("Description", headerFont, Brushes.Black, startX, yPos);
            g.DrawString("Qty", headerFont, Brushes.Black, startX + 300, yPos);
            g.DrawString("Unit Price", headerFont, Brushes.Black, startX + 400, yPos);
            g.DrawString("Total", headerFont, Brushes.Black, startX + 550, yPos);
            yPos += offset;
            g.DrawString("-----------------------------------------------------------------------------------", headerFont, Brushes.Black, startX, yPos);
            yPos += offset;

            g.DrawString(saleToPrint["ItemName"], bodyFont, Brushes.Black, startX, yPos);
            g.DrawString(saleToPrint["Quantity"], bodyFont, Brushes.Black, startX + 300, yPos);
            g.DrawString(saleToPrint["UnitPrice"], bodyFont, Brushes.Black, startX + 400, yPos);
            g.DrawString(saleToPrint["TotalAmount"], bodyFont, Brushes.Black, startX + 550, yPos);
            yPos += offset;
            g.DrawString("-----------------------------------------------------------------------------------", headerFont, Brushes.Black, startX, yPos);
            yPos += offset;

            g.DrawString("Total Amount:", headerFont, Brushes.Black, startX + 400, yPos);
            g.DrawString(saleToPrint["TotalAmount"], headerFont, Brushes.Black, startX + 550, yPos);
        }
    }
}