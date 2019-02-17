using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Studenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nume.Text != "" && oras.Text != "" && adresa.Text != "" && cnp.Text != "")
            {
                string constring = "datasource=127.0.0.1;port=3306;username=root;password=;";
                string Query = "INSERT INTO studenti.studenti(nume, oras, adresa, cnp)VALUES('" + this.nume.Text + "','" + this.oras.Text + "','" + this.adresa.Text + "','" + this.cnp.Text + "') ;";
                MySqlConnection conDatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;

                try
                {
                    conDatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Inserat cu succes in baza de date!");
                    while (myReader.Read())
                    {

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conDatabase.Close();
                nume.Clear();
                oras.Clear();
                adresa.Clear();
                cnp.Clear();
            }
              else
              {
                MessageBox.Show("Campurile trebuie ocupate!");
              }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;";
            string Query = "SELECT * FROM studenti.studenti";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdDatabase;
            conDatabase.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];
            listBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                
                listBox1.Items.Add("ID student:---------------------------");
                listBox1.Items.Add(dr["ID"].ToString());
                listBox1.Items.Add(dr["Nume"].ToString());               
                listBox1.Items.Add(dr["Oras"].ToString());
                listBox1.Items.Add(dr["Adresa"].ToString());
                listBox1.Items.Add(dr["CNP"].ToString());
                listBox1.Items.Add("--------------------------------------");              
            }
            conDatabase.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id_student.Text != "")
            {
                string constring = "datasource=127.0.0.1;port=3306;username=root;password=;";
                string Query = "DELETE FROM studenti.studenti WHERE Id = '" + this.id_student.Text + "';";
                MySqlConnection conDatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;
                  try
                  {
                     conDatabase.Open();
                     myReader = cmdDatabase.ExecuteReader();
                     MessageBox.Show(" Stergere cu succes!");
                     while (myReader.Read())
                     {

                     }
                    conDatabase.Close();
                   }

                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                  }
            }
            else
            {
                MessageBox.Show("ID student pentru a sterge!");
            }
            
            id_student.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           // int ID = 0;
           // ID = Convert.ToInt32(textBox1.Text.ToString());
           // ID = textBox1.Text;
        }
    }
   }
