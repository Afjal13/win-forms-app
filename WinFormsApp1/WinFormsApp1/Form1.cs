using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True;";

        public EmployeeForm()
        {
            InitializeComponent();
            DataTable dt = GetDataFromDB();
            EmployeedataGridView.AutoGenerateColumns = false;
            EmployeedataGridView.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string empId = txtId.Text.Trim();
                string empName = txtName.Text.Trim();
                int empSalary = 0;
                string empCity = txtCity.Text.Trim();

                if (string.IsNullOrEmpty(empId))
                {
                    MessageBox.Show(txtId, "Id is required.");
                    txtId.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(empName))
                {
                    MessageBox.Show(txtName, "Name is required.");
                    txtName.Focus();
                    return;
                }

                if (!int.TryParse(txtSalary.Text, out empSalary) || empSalary == 0)
                {
                    MessageBox.Show(txtSalary, "Invalid or empty salary. Please enter a valid number.");
                    txtSalary.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(empCity))
                {
                    MessageBox.Show(txtCity, "City is required.");
                    txtCity.Focus();
                    return;
                }

                if (IsAlreadyExit(empId))
                {
                    MessageBox.Show("Employee already exists!");
                    txtId.Focus();
                }
                else
                {
                    AddEmployee(empId, empName, empSalary, empCity);
                    MessageBox.Show("Add Successful!");
                    DataTable dt = GetDataFromDB();
                    EmployeedataGridView.AutoGenerateColumns = false;
                    EmployeedataGridView.DataSource = dt;
                    ClearField();
                    txtId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool IsAlreadyExit(string id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM EmployeeDetails WHERE empId = @empId";
                SqlCommand command = new SqlCommand(query, connection);
                //Add Parameter
                command.Parameters.AddWithValue("@empId", id);

                // Execute the query
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection.Close(); }
            return false;
        }

        private void AddEmployee(string id, string name, int salary, string city)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string insertQuery = "INSERT INTO EmployeeDetails (empId, empName, empSalary,empCity) VALUES (@empId, @empName, @empSalary,@empCity)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                // Add parameters
                command.Parameters.AddWithValue("@empId", id);
                command.Parameters.AddWithValue("@empName", name);
                command.Parameters.AddWithValue("@empSalary", salary);
                command.Parameters.AddWithValue("@empCity", city);
                // Execute the query
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateEmployeeDetails(string id, string name, int salary, string city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string insertQuery = "Update EmployeeDetails set empName=@empName,empSalary=@empSalary,empCity=@empCity where empId=@empId";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                // Add parameters                    
                command.Parameters.AddWithValue("@empName", name);
                command.Parameters.AddWithValue("@empSalary", salary);
                command.Parameters.AddWithValue("@empCity", city);
                command.Parameters.AddWithValue("@empId", id);
                // Execute the update query
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Update seccessful!");
                    DataTable dt = GetDataFromDB();
                    EmployeedataGridView.AutoGenerateColumns = false;
                    EmployeedataGridView.DataSource = dt; ClearField();
                }
                else { MessageBox.Show("Update failed!"); }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                txtId.ReadOnly = false;
                txtId.BackColor = System.Drawing.Color.White;
                btnSave.Enabled = true;
                btnSave.BackColor = System.Drawing.Color.White;
            }
        }

        private void DeleteEmployeeRecord(string id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string insertQuery = "Delete EmployeeDetails where empId=@empId";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                // Add parameters                    
                command.Parameters.AddWithValue("@empId", id);
                // Execute the update query
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Delete seccessful!");
                    DataTable dt = GetDataFromDB();
                    EmployeedataGridView.AutoGenerateColumns = false;
                    EmployeedataGridView.DataSource = dt; ClearField();
                }
                else { MessageBox.Show("Delete failed. EmployeeId not found or other issue."); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                txtId.ReadOnly = false;
                txtId.BackColor = System.Drawing.Color.White;
                btnSave.Enabled = true;
                btnSave.BackColor = System.Drawing.Color.White;
              
            }
        }

        private void ClearField()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtSearchId.Text = string.Empty;
        }

        private DataTable GetDataFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "select * from EmployeeDetails";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { connection.Close(); }
            return dt;
        }

        private void btnFindEmp_Click(object sender, EventArgs e)
        {
            string empId = txtSearchId.Text;
            if (IsAlreadyExit(empId))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    string query = "select * from EmployeeDetails where empId =@empId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@empId", empId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtId.Text = reader["empId"].ToString();
                        txtName.Text = reader["empName"].ToString();
                        txtSalary.Text = reader["empSalary"].ToString();
                        txtCity.Text = reader["empCity"].ToString();
                    }
                    txtId.ReadOnly = true;
                    txtId.BackColor = System.Drawing.Color.SlateGray;                  
                    btnSave.Enabled = false;
                    btnSave.BackColor = System.Drawing.Color.Gray;                   
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                finally { connection.Close(); }
            }
            else
            {
                MessageBox.Show("Invaild or not found!");
                txtSearchId.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string empId = txtId.Text.Trim();
            string empName = txtName.Text.Trim();
            int empSalary = Convert.ToInt32(txtSalary.Text);
            string empCity = txtCity.Text.Trim();
            UpdateEmployeeDetails(empId, empName, empSalary, empCity);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string empId = txtId.Text.Trim();
            DeleteEmployeeRecord(empId);
        }
    }
}
