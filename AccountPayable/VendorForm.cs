using System;
using ProgramController;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;

namespace AccountPayable
{
    public partial class VendorForm : Form
    {
        int currentUserId = LoginForm.currentUserId;
        public VendorForm()
        {
            InitializeComponent();
        }

        private void btnSearchVendor_Click(object sender, EventArgs e)
        {
            if (txtVendorCodeSearch.Text.Equals(""))
            {
                MessageBox.Show("Please fill out the Vendor Code text box", "Invalid Entry", MessageBoxButtons.OK);
                txtVendorCodeSearch.Focus();
                return;
            }

            var vendorInfo = SqlDataAccess.GetVendorInfo(Convert.ToInt32(txtVendorCodeSearch.Text), currentUserId);

            if (vendorInfo != null)
            {
                txtVendorName1.Text = vendorInfo.VendorName;
                txtVendorName1.ReadOnly = true;
                txtVendorCode1.Text = vendorInfo.VendorCode.ToString();
                txtVendorCode1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("The entered Vendor code does not exist", "Invalid Entry", MessageBoxButtons.OK);
                txtVendorCodeSearch.Focus();
                return;
            }
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            if (txtVendorCode1.ReadOnly)
            {
                txtVendorName1.ReadOnly = false;
                txtVendorCode1.ReadOnly = false;
                txtVendorName1.Focus();
                return;
            }

            VendorModel v = new VendorModel();
            if (txtVendorCode1.Text.Equals(""))
            {
                var r = new Random();
                v.VendorCode = r.Next(1000, 9999);
            }
            else
            {
                v.VendorCode = Convert.ToInt32(txtVendorCode1.Text);
            }

            v.VendorName = txtVendorName1.Text;
            v.Date = dateTimePicker1.Value.ToString();
            v.UserID = currentUserId;

            SqlDataAccess.AddVendor(v);
        }

        private void btnRemoveVendor_Click(object sender, EventArgs e)
        {
            if (txtVendorCode1.Text.Equals(""))
            {
                MessageBox.Show("No vendor is found", "Error", MessageBoxButtons.OK);
                txtVendorCodeSearch.Focus();
                return;
            }
            SqlDataAccess.RemoveVendor(Convert.ToInt32(txtVendorCode1.Text));

            txtVendorName1.ReadOnly = false;
            txtVendorCode1.ReadOnly = false;


        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (!SqlDataAccess.VendorExists(Convert.ToInt32(txtVendorCode2.Text)))
            {
                MessageBox.Show("The entered Vendor Code does not exist", "Invalid Entry", MessageBoxButtons.OK);
                return;
            }

            if (txtAmountPayed.Text.Equals("") || txtInvoiceAmount.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all the fields", "Invalid Entry", MessageBoxButtons.OK);
                txtVendorCode2.Focus();
                return;
            }

            InvoiceModel i = new InvoiceModel();

            var r = new Random();
            var id = r.Next(100000, 999999);
            i.InvoiceID = id;
            i.VendorCode = Convert.ToInt32(txtVendorCode2.Text);
            i.InvoiceAmount = Convert.ToDouble(txtInvoiceAmount.Text);
            i.Date = DateTime.Now.ToString();
            i.AmountPayed = 0;
            i.UserID = currentUserId;
            i.PayedFor = "False";

            SqlDataAccess.AddInvoice(i);
            SqlDataAccess.CreateTransaction(i.InvoiceID, i.VendorCode, i.InvoiceAmount);


            var invoice = SqlDataAccess.GetInvoiceInfo(id, currentUserId);
            if (invoice == null)
            {
                MessageBox.Show("No invoice is found", "Error", MessageBoxButtons.OK);
                txtInvoiceIDSearch.Focus();
                return;
            }
            ShowInvoice(invoice);
        }
        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            if (txtInvoiceIDSearch.Text.Equals(""))
            {
                MessageBox.Show("Please fill out the Invoice ID text box", "Invalid Entry", MessageBoxButtons.OK);
                txtInvoiceIDSearch.Focus();
                return;
            }

            var invoice = SqlDataAccess.GetInvoiceInfo(Convert.ToInt32(txtInvoiceIDSearch.Text), currentUserId);
            
            if (invoice == null)
            {
                MessageBox.Show("No invoice is found", "Error", MessageBoxButtons.OK);
                txtInvoiceIDSearch.Focus();
                return;
            }
            ShowInvoice(invoice);
        }

        public void ShowInvoice(InvoiceModel invoice)
        {
            txtVendorCode2.Text = invoice.VendorCode.ToString();
            txtInvoiceAmount.Text = invoice.InvoiceAmount.ToString();
            txtAmountPayed.Text = invoice.AmountPayed.ToString();
            txtInvoiceIdReadOnly.Text = invoice.InvoiceID.ToString();

            txtVendorCode2.ReadOnly = true;
            txtInvoiceAmount.ReadOnly = true;
            txtAmountPayed.ReadOnly = true;
        }

        private void btnSearchVendor2_Click(object sender, EventArgs e)
        {
            invoiceGridView.Rows.Clear();
            if (!SqlDataAccess.VendorExists(Convert.ToInt32(txtSearchVendorCode2.Text)))
            {
                MessageBox.Show("The entered Vendor Code does not exist", "Invalid Entry", MessageBoxButtons.OK);
                return;
            }
            var temp = SqlDataAccess.GetAllInvoices(Convert.ToInt32(txtSearchVendorCode2.Text), currentUserId);

            foreach (DataRow row in temp.Rows)
            {
                var rowArray = row.ItemArray;
                invoiceGridView.Rows.Add(rowArray[0], rowArray[1], rowArray[2], rowArray[3]);
            }
            invoiceGridView.Columns["AmountPayed"].ReadOnly = false;
        }

        private void invoiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            int vc;
            if (e.ColumnIndex == 4)
            {
                id = Convert.ToInt32(invoiceGridView.Rows[e.RowIndex].Cells[0].Value);
                vc = Convert.ToInt32(invoiceGridView.Rows[e.RowIndex].Cells[1].Value);

                var aPayed = Convert.ToDouble(invoiceGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (aPayed > Convert.ToDouble(invoiceGridView.Rows[e.RowIndex].Cells[2].Value.ToString()))
                {
                    MessageBox.Show("Amount Payed can not be higher than total invoice fee", "Invalid Entry", MessageBoxButtons.OK);
                    return;
                }
                SqlDataAccess.UpdateInvoice(id, aPayed);
                SqlDataAccess.CreateTransaction(id, vc, aPayed);


                MessageBox.Show($"Invoice {id} updated", "", MessageBoxButtons.OK);
            }
        }
        private void btnGenerateCS_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();

            var before = dtpBefore.Value.ToString().Split(' ')[0].Split('/');
            var beforeDate = new DateTime(Convert.ToInt32(before[2]), Convert.ToInt32(before[0]), Convert.ToInt32(before[1]));
            var after = dtpAfter.Value.ToString().Split(' ')[0].Split('/');
            var afterDate = new DateTime(Convert.ToInt32(after[2]), Convert.ToInt32(after[0]), Convert.ToInt32(after[1]));

            var allData = SqlDataAccess.GetTreeData();
            double totalDue = 0;
            double totalPayed = 0;

            foreach (var vendorCode in allData.Keys)
            {
                var s = $"Vendor Name: {SqlDataAccess.GetVendorName(Convert.ToInt32(vendorCode))} | Vendor Code: {vendorCode}";
                treeView.Nodes.Add(new TreeNode(s));
                foreach (var invoiceKey in allData[vendorCode].Keys)
                {
                    var transDateSplit = allData[vendorCode][invoiceKey].Date.Split(' ')[0].Split('/');
                    var dateToCheck = new DateTime(Convert.ToInt32(transDateSplit[2]), Convert.ToInt32(transDateSplit[0]), Convert.ToInt32(transDateSplit[1]));
                    if (dateToCheck < beforeDate || dateToCheck > afterDate)
                    {
                        return;
                    }
                    totalDue += allData[vendorCode][invoiceKey].InvoiceAmount;
                    var s2 = $"Invoice ID: {allData[vendorCode][invoiceKey].InvoiceID} | Invoice Amount: {allData[vendorCode][invoiceKey].InvoiceAmount}";
                    treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add(s2);

                    int highestIndex = -1;
                    double highestAmtPayed = 0;
                    foreach (var trans in allData[vendorCode][invoiceKey].Transactions)
                    {
                        var transDateSplit2 = trans.Date.Split(' ')[0].Split('/');
                        var dateToCheck2 = new DateTime(Convert.ToInt32(transDateSplit2[2]), Convert.ToInt32(transDateSplit2[0]), Convert.ToInt32(transDateSplit2[1]));
                        if (dateToCheck2 < beforeDate || dateToCheck2 > afterDate)
                        {
                            return;
                        }
                        if (trans.AmountPayed > highestAmtPayed)
                        {
                            highestIndex = allData[vendorCode][invoiceKey].Transactions.IndexOf(trans);
                            highestAmtPayed = trans.AmountPayed;
                        }
                        var s3 = $"Date: {trans.Date} | Amount Payed: {trans.AmountPayed}";
                        treeView.Nodes[treeView.Nodes.Count - 1].Nodes[treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(s3);
                    }
                    totalPayed += highestAmtPayed;
                }
            }
            lbTotAmtDue.Text = String.Format("{0:C}", totalDue);
            lbTotAmtPayed.Text = String.Format("{0:C}", totalPayed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVendorCode2.ReadOnly = false;
            txtVendorCode2.Text = "";
            txtInvoiceAmount.ReadOnly = false;
            txtInvoiceAmount.Text = "";
            txtAmountPayed.ReadOnly = false;
            txtAmountPayed.Text = "";
        }
    }
}
