using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True;";

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string empId = txtId.Text;
            string empName = txtName.Text;
            int empSalary = Convert.ToInt32(txtSalary.Text);
            string empCity = txtCity.Text;

            if (IsAlreadyExit(empId))
            {
                MessageBox.Show("Employee already exit!");               
                txtId.Focus();
            }
            else
            {
                AddEmployee(empId, empName, empSalary, empCity);
                MessageBox.Show("Add Successful!");
                ClearField();
                txtId.Focus();
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO EmployeeDetails (empId, empName, empSalary,empCity) VALUES (@empId, @empName, @empSalary,@empCity)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@empId", id);
                        command.Parameters.AddWithValue("@empName", name);
                       
                        command.Parameters.AddWithValue("@empSalary", salary);
                        command.Parameters.AddWithValue("@empCity", city);

                        // Execute the query
                        command.ExecuteNonQuery();
                        //Application.Exit();
                    }
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
        }

        private void ClearField()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtCity.Text = string.Empty;
        }
    }
}
