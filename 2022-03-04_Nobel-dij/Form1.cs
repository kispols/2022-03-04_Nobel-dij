using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_03_04_Nobel_dij
{
    public partial class OrvosiNobeldijasokGUI : Form
    {
        public OrvosiNobeldijasokGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMentés_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || textBox3.Text.Length < 1 || textBox4.Text.Length < 1)
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
