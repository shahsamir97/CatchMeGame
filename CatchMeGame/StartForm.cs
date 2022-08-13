using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CatchMeGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        //Objects of other class
        NameAndAgeInputForm ng = new NameAndAgeInputForm();

        private void SavePlayerName()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ng.Visible = true;
            this.Hide();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
