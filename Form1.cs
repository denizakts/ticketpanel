using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblva.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = lblva.Text;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            Registered_Passenger_Information.Items.Clear();
            maskedTextBox1.Clear();
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            dtp.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registered_Passenger_Information.Items.Add("Departure: " + comboBox1.Text + " " + "Arrival: " + comboBox2.Text + " " + "Date: " + dtp.Text);

            if (checkBox1.Checked == true)
            {
                Registered_Passenger_Information.Items.Add("Name: " + textBox1.Text + " " + " Surname: " + textBox2.Text + " " + "Country:" + textBox4.Text + " " + "Sex :" + checkBox1.Text);
            }
            else
            {
                Registered_Passenger_Information.Items.Remove("Name: " + textBox1.Text + " " + " Surname: " + textBox2.Text + " " + "Country:" + textBox4.Text + " " + "Sex: " + checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                Registered_Passenger_Information.Items.Add("Name: " + textBox1.Text + " " + " Surname: " + textBox2.Text + " " + "Country:" + textBox4.Text+ " " + "Sex: " + checkBox2.Text);
            }
            else
            {
                Registered_Passenger_Information.Items.Remove("Name: " + textBox1.Text + " " + " Surname: " + textBox2.Text + " " + "Country:" + textBox4.Text + " " + "Sex: " + checkBox2.Text);
            }
            MessageBox.Show("Passenger information has been saved succesfully");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
