using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadData();
            
        }

        public void Save()
        {
            try
            {
                if (namefield.Text == "" || sexfield.Text == "" || addressfield.Text == "")
                {
                    bool error = namefield.Text == "" ? namefield.Focus() : sexfield.Text == "" ? sexfield.Focus() : addressfield.Text == ""? addressfield.Focus() : true;
                    throw new Exception("Some Field are Empty.");
                }
                string conString = "datasource=localhost;username=root;";
                string query = "INSERT INTO dbemp.tblemployee (name,sex,address) VALUES ('"
                    + namefield.Text + "', '"
                    + sexfield.Text + "', '"
                    + addressfield.Text + "')";

                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader;
                con.Open();
                MessageBox.Show("New Record Inserted...");
                reader = cmd.ExecuteReader();
                con.Close();


            } catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
            LoadData();
        }

        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string conString = "datasource=localhost;username=root;";
            string query = "SELECT * FROM dbemp.tblemployee";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("name");
                    string sex = reader.GetString("sex");
                    string address = reader.GetString("address");
                    dataGridView1.Rows.Add(name, sex, address);
                }
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                {
                    edit.Name = "edit";
                    edit.HeaderText = "Edit";
                    edit.Text = "Edit";
                    edit.UseColumnTextForButtonValue = true;
                    if(dataGridView1.Columns["edit"] == null)
                        dataGridView1.Columns.Add(edit);
                }
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                {
                    delete.Name = "delete";
                    delete.HeaderText = "Delete";
                    delete.Text = "Delete";
                    delete.UseColumnTextForButtonValue = true;
                    if(dataGridView1.Columns["delete"] == null)
                        dataGridView1.Columns.Add(delete);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                editform editform = new editform(data.Cells[0].Value.ToString(), data.Cells[1].Value.ToString(), data.Cells[2].Value.ToString(), this);
                editform.Show();
            }
            else if(e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                DialogResult result =  MessageBox.Show("Are you sure you want to delete this data?","Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        string conString = "datasource=localhost;username=root;";
                        string query = "DELETE FROM dbemp.tblemployee WHERE name='"+data.Cells[0].Value.ToString()+ "'";
                        MySqlConnection con = new MySqlConnection(conString);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader reader;
                        con.Open();
                        MessageBox.Show("Successfuly deleted");
                        reader = cmd.ExecuteReader();
                        con.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.LoadData();
                }
            }
        }

        public void ClearFields()
        {
            namefield.Text = "";
            sexfield.Text = "";
            addressfield.Text = "";
            namefield.Focus();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void loaddata_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
