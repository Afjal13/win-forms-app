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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO EmployeeDetails (empId, empName, empSalary,empCity) VALUES (@empId, @empName, @empSalary,@empCity)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@empId", empId);
                        command.Parameters.AddWithValue("@empName", empName);
                        command.Parameters.AddWithValue("@empSalary", empSalary);
                        command.Parameters.AddWithValue("@empCity", empCity);

                        // Execute the query
                        command.ExecuteNonQuery();
                        Application.Exit();
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
    }
}
