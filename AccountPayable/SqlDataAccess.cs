using Dapper;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.SQLite;
using System.Diagnostics;

namespace ProgramController
{
    public class SqlDataAccess
    {
        public static int GetUserID(string username, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Users")))
            {
                var output = cnn.Query($"select * from Users where Username==@username and Password==@password", new { username, password }).ToList();
                if (output.Count() >= 1)
                {
                    return (int)output.First().ID;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static bool VendorExists(int vendorCode)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Vendors")))
            {
                var output = cnn.Query($"select * from Vendors where VendorCode=={vendorCode}", new DynamicParameters()).ToList();
                return output.Count >= 1 ? true : false;
            }
        }

        public static string GetVendorName(int vendorCode)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Vendors")))
            {
                var output = cnn.Query($"select VendorName from Vendors where VendorCode=={vendorCode}", new DynamicParameters()).ToList();
                return output.First().VendorName;
            }
        }

        public static Dictionary<string, Dictionary<string, InvoiceModel>> GetTreeData()
        {
            Dictionary<string, Dictionary<string, InvoiceModel>> allData = new Dictionary<string, Dictionary<string, InvoiceModel>>();

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Vendors")))
            {
                var output = cnn.Query($"select VendorCode from Vendors", new DynamicParameters()).ToList();
                foreach (var code in output)
                {
                    allData.Add(code.VendorCode.ToString(), new Dictionary<string, InvoiceModel>());
                }
            }
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Invoices")))
            {
                var output = cnn.Query($"select * from Invoices", new DynamicParameters()).ToList();
                foreach (var invoice in output)
                {
                    var i = new InvoiceModel();
                    i.InvoiceID = Convert.ToInt32(invoice.InvoiceID);
                    i.VendorCode = Convert.ToInt32(invoice.VendorCode);
                    i.InvoiceAmount = Convert.ToDouble(invoice.InvoiceAmount);
                    i.Date = invoice.Date.ToString();
                    i.AmountPayed = Convert.ToDouble(invoice.AmountPayed);
                    i.UserID = Convert.ToInt32(invoice.UserID);
                    i.PayedFor = Convert.ToDouble(invoice.AmountPayed) == Convert.ToDouble(invoice.InvoiceAmount) ? "True" : "False";
                    i.Transactions = new List<TransactionModel>();
                    allData[invoice.VendorCode.ToString()].Add(i.InvoiceID.ToString(), i);

                }
                using (IDbConnection con = new SQLiteConnection(LoadConnectionString("Transactions")))
                {
                    var allTrans = con.Query($"select * from Transactions", new DynamicParameters()).ToList();
                    foreach (var transaction in allTrans)
                    {
                        var t = new TransactionModel();
                        t.AmountPayed = transaction.AmountPayed;
                        t.Date = transaction.Date;
                        var temp = allData[transaction.VendorCode.ToString()][transaction.InvoiceID.ToString()];
                        allData[transaction.VendorCode.ToString()][transaction.InvoiceID.ToString()].Transactions.Add(t);
                    }
                }
            }

            return allData;
        }
        public static void AddUser(string firstName, string lastName, string username, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Users")))
            {
                cnn.Execute("insert into Users (FirstName, LastName, Username, Password) values (@firstName, @lastName, @username, @password)", new { firstName, lastName, username, password });
            }
        }

        public static void AddVendor(VendorModel vendor)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Vendors")))
            {
                cnn.Execute("insert into Vendors (VendorCode, VendorName, DateAdded, UserID) values (@vendorCode, @vendorName, @date, @userID)", new { vendor.VendorCode, vendor.VendorName, vendor.Date, vendor.UserID });
            }
        }

        public static void RemoveVendor(int vendorCode)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Vendors")))
            {
                cnn.Execute("delete from Vendors where VendorCode==@vendorCode", new { vendorCode });
            }
        }

        public static VendorModel GetVendorInfo(int vendorCode, int userID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Vendors")))
            {
                var output = cnn.Query<VendorModel>($"select * from Vendors where VendorCode=={vendorCode} and UserID=={userID}", new DynamicParameters());
                if (output.Count() >= 1)
                {
                    return output.ToList()[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static void AddInvoice(InvoiceModel i)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Invoices")))
            {
                cnn.Execute("insert into Invoices (InvoiceID, VendorCode, InvoiceAmount, Date, AmountPayed, UserID, PayedFor) values (@invoiceID, @vendorCode, @invoiceAmount, @date, @amountPayed, @userID, @payedFor)",
                    new { i.InvoiceID, i.VendorCode, i.InvoiceAmount, i.Date, i.AmountPayed, i.UserID, i.PayedFor });
            }
        }

        public static InvoiceModel GetInvoiceInfo(int invoiceID, int userID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Invoices")))
            {
                var output = cnn.Query<InvoiceModel>($"select * from Invoices where InvoiceID=={invoiceID} and UserID=={userID}", new DynamicParameters());
                if (output.Count() >= 1)
                {
                    return output.ToList()[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static void UpdateInvoice(int invoiceId, double updatedAmountPayed)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Invoices")))
            {
                cnn.Execute($"update Invoices set AmountPayed={updatedAmountPayed} where InvoiceID=={invoiceId}", new DynamicParameters());
            }
        }
        public static void CreateTransaction(int invoiceID, int vendorCode, double updatedAmountPayed)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("Transactions")))
            {
                var tNow = DateTime.Now.ToString();
                cnn.Execute("insert into Transactions (InvoiceID, VendorCode, Date, AmountPayed) values (@invoiceID, @vendorCode, @tNow, @updatedAmountPayed)",
                    new { invoiceID, vendorCode, tNow, updatedAmountPayed });
            }
        }
        public static DataTable GetAllInvoices(int vendorCode, int userID)
        {
            var con = new SQLiteConnection(LoadConnectionString("Invoices"));
            con.Open();
            var cmd = new SQLiteCommand($"select InvoiceID, VendorCode, InvoiceAmount, AmountPayed from Invoices where VendorCode=={vendorCode} and UserID=={userID}", con);
            var adapter = new SQLiteDataAdapter(cmd);

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static string LoadConnectionString(string id)
        {
            var temp = ConfigurationManager.ConnectionStrings[id].ConnectionString;
            Debug.Print(temp);
            return temp;
        }

    }
}
