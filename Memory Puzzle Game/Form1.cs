using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Memory_Puzzle_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEasyLevel_Click(object sender, EventArgs e)
        {
            var easyForm = new EasyForm(this);
            if (cbTheme.SelectedIndex == -1)
            {
                var result = MessageBox.Show("Please choose a theme");
            }
            else
            {
                easyForm.Show();
                this.Hide();
            }

        }

        private void btnMediumLevel_Click(object sender, EventArgs e)
        {
            var mediumForm = new MediumForm(this);
            if (cbTheme.SelectedIndex == -1)
            {
                var result = MessageBox.Show("Please choose a theme");
            }
            else
            {
                mediumForm.Show();
                this.Hide();
            }
        }

        private void btnHardLevel_Click(object sender, EventArgs e)
        {
            var hardForm = new HardForm(this);
            if (cbTheme.SelectedIndex == -1)
            {
                var result = MessageBox.Show("Please choose a theme");
            }
            else
            {
                string selectedTheme = cbTheme.SelectedItem.ToString();
                hardForm.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string SelectedTheme
        {
            get { return cbTheme.SelectedItem?.ToString() ?? ""; }
        }

    }
}
