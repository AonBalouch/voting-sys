using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_voting_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load (object sender, EventArgs e)
        {

           


        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // Form3 f2 = new Form3();
            //f2.ShowDialog(); // Shows Form2
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((this.textBox1.Text == "aon") && (this.textBox2.Text == "123"))
            
            {
                this.Hide();
                var form3 = new Form3();
                form3.Closed += (s, args) => this.Close();
                form3.Show();

            }

            else
            {
                MessageBox.Show("Invalid username or password !");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
