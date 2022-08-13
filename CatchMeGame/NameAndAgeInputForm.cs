using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CatchMeGame
{
    public partial class NameAndAgeInputForm : Form
    {
        public NameAndAgeInputForm()
        {
            InitializeComponent();
        }

        String name;
        int age;
        private void button1_Click(object sender, EventArgs e)
        {
            name = nameTxt.Text;
           // age = ageTxt.Text;

            this.Hide();
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        public String GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        private void NameAndAgeInputForm_Load(object sender, EventArgs e)
        {
            nameTxt.Text = "";
            ageTxt.Text = "";
        }
    }
}
