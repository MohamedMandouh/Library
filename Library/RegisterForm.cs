using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //get all required fields
            string name = textBox1.Text;
            string genre = textBox2.Text;
            int index = int.Parse(textBox3.Text);

           //constructs a book object with given fields
            Book b = new Book(name,genre,index);

            //TODO : 
            //Now pass the object to the database


            //close the form
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
