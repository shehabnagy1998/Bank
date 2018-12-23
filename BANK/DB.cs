using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace BANK
{
    class DB
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=shehab90");
        string firstName, lastName, job, address, country, civilStatus, gender, natID, phoneNumber;
        string monthlyPayment, age, openBal, userName, password, from, to, value;
        string[] client_info = new string[4];
        string cid, type, amount, date, branch;
        public DB(string cid, string type, string amount, string date, string branch) {
            this.cid = cid;
            this.type = type;
            this.amount = amount;
            this.date = date;
            this.branch = branch;
        }
        public DB(string fn = "", string ln = "", string j = "", string add = "", string countr = "", string civil = "", string gend = "", string mo = "", string natid = "", string pn = "", string openbal = "", string ag = "")
        {
            firstName = fn;
            lastName = ln;
            job = j;
            address = add;
            country = countr;
            civilStatus = civil;
            gender = gend;
            monthlyPayment = mo;
            phoneNumber = pn;
            openBal = openbal;
            natID = natid;
            age = ag;
        }
        public DB(string natID)
        {
            this.natID = natID;
        }
        public DB(string username, string password)
        {
            userName = username;
            this.password = password;
        }
        public DB(string from, string to, string value)
        {
            this.from = from;
            this.to = to;
            this.value = value;
        }


        // add new account to database
        public void NewAccount()
        {
            string query = "insert into bankdb.client (FirstName, LastName, CID, MonthlyPay, Phone, OpenBalance, Balance, Job, Country, Status, Gender, DOB) values ('" + firstName + "', '" + lastName + "', '" + natID + "', '" + monthlyPayment + "','" + phoneNumber + "', '" + openBal + "', '" + openBal + "', '" + job + "', '" + country + "', '" + civilStatus + "', '" + gender + "', '" + age + "')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Client has been added", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        // Check if client exist in database
        public bool Find(string natid)
        {
            bool found = false;
            int coun = 0;
            string query = "select FirstName, LastName from bankdb.client where CID = '" + natid + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coun++;
                    client_info[0] = reader[0].ToString();
                    client_info[1] = reader[1].ToString();
                }
                if (coun == 1)
                {
                    found = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return found;
        }
        // Delete client from database
        public void DeleteAccount()
        {
            bool IsThere = Find(natID);
            if (IsThere == true)
            {
                DialogResult di = MessageBox.Show($"Are u sure u want to delete the account of client {client_info[0]} {client_info[1]}", "Delete", MessageBoxButtons.YesNo);
                if (di == DialogResult.Yes)
                {
                    string query = "delete from bankdb.client where CID = '" + natID + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Account of client {client_info[0]} {client_info[1]} has been deleted", "Failed");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    di = DialogResult.Cancel;
                }
            }
            else
            {
                MessageBox.Show("There is no Client account with this National ID", "Failed");
            }
        }

        // Check username and password of the user, check for the job description
        public bool[] LogIn()
        {
            int count = 0;
            bool[] yes = { false, false };
            string query = "select * from bankdb.employee where FirstName = '" + userName + "' and EmpID = '" + password + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                    string manger = reader.GetString("MgrID");
                }
                if (count == 1)
                {
                    yes[0] = true;
                }
            }
            catch (SqlNullValueException e) {
                yes[1] = true;
                if (count == 1)
                {
                    yes[0] = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return yes;
        }

        // to know the balance of some client
        public double KnowBalance(string natid)
        {
            double balance = 0;
            string query = "select Balance from bankdb.client where CID = '" + natid + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    balance = Convert.ToDouble(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return balance;
        }

        // insert amount of money to someone account
        public void InsertBalance(string bal, string natid)
        {
            string query = "update bankdb.client set Balance = '" + bal + "' where CID = '" + natid + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Get specific client info
        public string[] KnowInfo()
        {
            string query = "select FirstName, LastName, Phone, Balance from bankdb.client where CID = '" + natID + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    client_info[0] = reader[0].ToString();
                    client_info[1] = reader[1].ToString();
                    client_info[2] = reader[2].ToString();
                    client_info[3] = reader[3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return client_info;
        }

        // count number of columns in table
        public string count(string col, string table) {
            string query = $"select count({col}) from bankdb.{table}";
            string c = ""; 
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    c = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return c;
        }

        // Get specific employee info
        public string[] KnowEmpInfo(string empID)
        {
            string query = "select * from bankdb.employee where EmpID = '" + empID + "'";
            string[] emp = new string[6];
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp[0] = reader[1].ToString();
                    emp[1] = reader[2].ToString();
                    emp[2] = reader[3].ToString();
                    emp[3] = reader[4].ToString();
                    emp[4] = reader[6].ToString();
                    emp[5] = reader[7].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return emp;
        }

        // Get loan 
        public void getLoan() {
            string query1 = "insert into bankdb.loan(Type, Amount, Date, BranchNo) values ('" + type + "', '" + amount + "', '" + date + "', '" + branch + "')";
            MySqlCommand comd = new MySqlCommand(query1, conn);
            try
            {
                conn.Open();
                comd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            string len = count("*", "loan");
            string query2 = "insert into bankdb.borrow values ('" + len + "', '" + cid + "')";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            try
            {
                conn.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("success", "Loan is completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Get a list of clients loans 
        public List<object> getLoans() {
            string query = "select * from bankdb.borrow where CID = '" + natID + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            List<object> items = new List<object>();
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(reader[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return items;
        }

        // Get loan detail
        public string[] knowLoanInfo(string loanID)
        {
            string query = "select * from bankdb.loan where LoanID = '" + loanID + "'";
            string[] loans = new string[4];
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    loans[0] = reader[1].ToString();
                    loans[1] = reader[2].ToString();
                    loans[2] = reader[3].ToString().Replace("12:00:00 AM", " ");
                    loans[3] = reader[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return loans;
        }
    }
}
