using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;



namespace Hospital_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void AddPtient_click(object sender, EventArgs e)
        {
            AddPatientTextBox.BackColor = System.Drawing.Color.Green;
            AddPatientpanel.Visible = true;
        }

        private void PatientApoointment_click(object sender, EventArgs e)
        {
            PatientappointmentTextBox.BackColor = System.Drawing.Color.Green;
        }

        private void Exit_click(object sender, EventArgs e)
        {
            //Exitbtn.BackColor = System.Drawing.Color.Red;
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            AddPatientpanel.Visible = false;
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPatientpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PRecordLabel_Click(object sender, EventArgs e)
        {

        }

        private void continue_click(object sender, EventArgs e)
        {
           
            //NewInfopanel.Visible = true;
        }

        private void save_click(object sender, EventArgs e)
        {
            String name = NametextBox.Text;
            String gender = patientGendercomboBox.Text;
            int age = Convert.ToInt32(AgetextBox.Text);
            Int64 phnno= Convert.ToInt64(PhnotextBox.Text);
            String bloodGroup = BloodGroupcomboBox.Text;
            String anyWard = WardInfocomboBox.Text;
            String WardType = WardTypeTextBox.Text;
            String DoctorName = DoctornametextBox.Text;
            String symptoms = PatientDiseasetextBox.Text;
            String Medicine = MedicinetextBox.Text;
            String address = PatientAddresstextBox.Text;
            String Diseases = PatientDiseasetextBox.Text;

            // Connection string for SQL Server
            string connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;User ID=YourUsername;Password=YourPassword";

            // Creating a SqlConnection object
            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Code to interact with the database using the 'connection' object
            }


        }
    }
}
