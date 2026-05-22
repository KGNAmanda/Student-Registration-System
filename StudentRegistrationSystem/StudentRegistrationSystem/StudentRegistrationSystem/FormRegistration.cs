using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class FormRegistration : Form
    {
        //private object dtpdateOfBirth;

        public FormRegistration()
        {
            InitializeComponent();
            LoadRegNos();
        }

        private string GetConnectionString()
        {
            return "Data Source=DESKTOP-TM410BM;Initial Catalog=Students;Integrated Security=True;Encrypt=False;";
        }

        private void LoadRegNos()
        {
            comboRegNo.Items.Clear();
            comboRegNo.Items.Add("");
            try
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                using (var cmd = new SqlCommand("SELECT regNo FROM RegistrationForm ORDER BY regNo", conn))
                {
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            comboRegNo.Items.Add(rdr.GetInt32(0).ToString());
                        }
                    }
                }
            }
            catch
            {
                // ignore
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtHomePhone.Text = string.Empty;
            txtParentName.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            dtpdateOfBirth.Value = DateTime.Today;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            comboRegNo.SelectedIndex = -1;
            txtFirstName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter first and last name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(comboRegNo.Text, out int regNoVal))
            {
                MessageBox.Show("Please enter a valid numeric Registration No.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                using (var cmd = new SqlCommand(
                    "INSERT INTO RegistrationForm (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                    "VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)", conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNoVal);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dtpdateOfBirth.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", radioMale.Checked ? "Male" : (radioFemale.Checked ? "Female" : ""));
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@mobilePhone", int.TryParse(txtMobile.Text, out int mp) ? (object)mp : DBNull.Value);
                    cmd.Parameters.AddWithValue("@homePhone", int.TryParse(txtHomePhone.Text, out int hp) ? (object)hp : DBNull.Value);
                    cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                    cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@contactNo", int.TryParse(txtContactNo.Text, out int cn) ? (object)cn : DBNull.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Student registered successfully.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegNos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while registering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboRegNo.Text))
            {
                MessageBox.Show("Select a registration number to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(comboRegNo.Text, out int regNoVal))
            {
                MessageBox.Show("Please enter a valid numeric Registration No.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                using (var cmd = new SqlCommand(
                    "UPDATE RegistrationForm SET firstName=@firstName, lastName=@lastName, dateOfBirth=@dateOfBirth, gender=@gender, " +
                    "address=@address, email=@email, mobilePhone=@mobilePhone, homePhone=@homePhone, parentName=@parentName, nic=@nic, contactNo=@contactNo " +
                    "WHERE regNo=@regNo", conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNoVal);
                    cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth", ((System.Windows.Forms.DateTimePicker)dtpdateOfBirth).Value.Date);
                    cmd.Parameters.AddWithValue("@gender", radioMale.Checked ? "Male" : (radioFemale.Checked ? "Female" : ""));
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@mobilePhone", int.TryParse(txtMobile.Text, out int mp) ? (object)mp : DBNull.Value);
                    cmd.Parameters.AddWithValue("@homePhone", int.TryParse(txtHomePhone.Text, out int hp) ? (object)hp : DBNull.Value);
                    cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                    cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@contactNo", int.TryParse(txtContactNo.Text, out int cn) ? (object)cn : DBNull.Value);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Record updated successfully." : "No record found to update.", "Update", MessageBoxButtons.OK,
                        rows > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboRegNo.Text))
            {
                MessageBox.Show("Select a registration number to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(comboRegNo.Text, out int regNoVal))
            {
                MessageBox.Show("Please enter a valid numeric Registration No.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var r = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new SqlConnection(GetConnectionString()))
                    using (var cmd = new SqlCommand("DELETE FROM RegistrationForm WHERE regNo=@regNo", conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", regNoVal);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRegNos();
                            btnClear_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("No record found to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboRegNo_DropDown(object sender, EventArgs e)
        {
            LoadRegNos();
        }

        private void comboRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboRegNo.Text))
            {
                FillFieldsByRegNo(comboRegNo.Text);
            }
        }

        private void comboRegNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboRegNo.Text))
            {
                FillFieldsByRegNo(comboRegNo.Text);
            }
        }

        private void FillFieldsByRegNo(string regNo)
        {
            if (!int.TryParse(regNo, out int regNoVal)) return;

            try
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                using (var cmd = new SqlCommand(
                    "SELECT firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo " +
                    "FROM RegistrationForm WHERE regNo=@regNo", conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNoVal);
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtFirstName.Text = rdr[0] as string ?? string.Empty;
                            txtLastName.Text = rdr[1] as string ?? string.Empty;
                            //dtpdateOfBirth.Value = rdr.IsDBNull(2) ? DateTime.Today : rdr.GetDateTime(2);
                            var g = rdr[3] as string ?? string.Empty;
                            radioMale.Checked = g == "Male";
                            radioFemale.Checked = g == "Female";
                            txtAddress.Text = rdr[4] as string ?? string.Empty;
                            txtEmail.Text = rdr[5] as string ?? string.Empty;
                            txtMobile.Text = rdr.IsDBNull(6) ? "" : rdr.GetInt32(6).ToString();
                            txtHomePhone.Text = rdr.IsDBNull(7) ? "" : rdr.GetInt32(7).ToString();
                            txtParentName.Text = rdr[8] as string ?? string.Empty;
                            txtNIC.Text = rdr[9] as string ?? string.Empty;
                            txtContactNo.Text = rdr.IsDBNull(10) ? "" : rdr.GetInt32(10).ToString();
                        }
                    }
                }
            }
            catch
            {
                // ignore
            }
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (var f = new Form1Login())
            {
                f.ShowDialog();
            }
            this.Show();
        }
    }
}