using Microsoft.Data.SqlClient;
using System.Data;

namespace winform
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=DESKTOP-EFA1UON;Database=patients;Trusted_Connection=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
           


           
            string query = "SELECT * FROM dbo.patientstable";

            
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionString))
            {
                
                DataTable dataTable = new DataTable();

               
                dataAdapter.Fill(dataTable);

               
                dataGridView1.DataSource = dataTable;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int id = int.Parse(patientid.Text);
                string fullName = name.Text;
                string dob = birthdate.Text;
                string gender = sex.Text; 
                int phone = int.Parse(mob.Text);
                try
                {

                    if (phone >= 500000000 && phone <= 599999999)
                    {
                     phone=phone ; 
                                              
                    }
                    else
                    {
                        
                        MessageBox.Show("The mobile number must start with 5 and be a 9-digit number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    
                }
                catch (FormatException)
                {
                    
                    MessageBox.Show("Please enter a valid numeric mobile number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                string address = birthplace.Text;

                string query = "INSERT INTO dbo.patientstable (Id,სახელი, [დაბადების თარიღი], სქესი, [მობილური ნომერი], მისამართი) VALUES (@Id,@Name, @Dateofbirth, @Gender, @Phone, @Address)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", fullName);
                        command.Parameters.AddWithValue("@Dateofbirth", dob);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Record added successfully!");
                            LoadData(); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int idToUpdate = int.Parse(patientid.Text);
            string newFullName = name.Text;
            string newDob = birthdate.Text;
            string newGender = sex.Text;
           
            int newPhone = int.Parse(mob.Text);
            string newAddress = birthplace.Text;

            string query = "UPDATE dbo.patientstable SET სახელი = @Name, [დაბადების თარიღი] = @DateOfBirth, სქესი = @Gender, [მობილური ნომერი] = @Phone, მისამართი = @Address WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", newFullName);
                    command.Parameters.AddWithValue("@DateOfBirth", newDob);
                    command.Parameters.AddWithValue("@Gender", newGender);
                    command.Parameters.AddWithValue("@Phone", newPhone);
                    command.Parameters.AddWithValue("@Address", newAddress);
                    command.Parameters.AddWithValue("@ID", idToUpdate);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                            LoadData(); // Refresh the DataGridView to show the updated record
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthplace_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string idToDelete = patientid.Text;

            
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM dbo.patientstable WHERE ID = @ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", idToDelete);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully!");
                                LoadData(); 
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified ID.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
