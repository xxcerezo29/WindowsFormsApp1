using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class editform : Form
    {
        public string prevName;
        Form1 main;
        public editform(string name, string sex, string address, Form1 main)
        {
            InitializeComponent();
            prevName = name;
            namefield.Text = name;
            sexfield.Text = sex;
            addressfield.Text = address;
            this.main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editform_Load(object sender, EventArgs e)
        {

        }

        private void namefield_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (namefield.Text == "" || sexfield.Text == "" || addressfield.Text == "")
                {
                    bool error = namefield.Text == "" ? namefield.Focus() : sexfield.Text == "" ? sexfield.Focus() : addressfield.Text == "" ? addressfield.Focus() : true;
                    throw new Exception("Some Field are Empty.");
                }
                string conString = "datasource=localhost;username=root;";
                string query = "UPDATE dbemp.tblemployee SET name = '"+
                    namefield.Text + "', sex='"+
                    sexfield.Text + "', address='"+
                    addressfield.Text+"' where name='"+prevName+"'";

                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;
                con.Open();
                MessageBox.Show("Record Updated...");
                reader = cmd.ExecuteReader();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.main.LoadData();
            this.Close();
        }
    }
}
