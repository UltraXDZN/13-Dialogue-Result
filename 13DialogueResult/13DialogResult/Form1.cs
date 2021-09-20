using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13DialogResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msgBoxOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialogueRez = MessageBox.Show("Press a button!", "Dialogue Box", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            string rezText;

            switch (dialogueRez)
            {
                case DialogResult.Yes:
                    multiLineTextMsgBox.Text = "Izabrali ste dugme YES";
                    break;
                case DialogResult.No:
                    multiLineTextMsgBox.Text = "Izabrali ste dugme NO";
                    break;
                case DialogResult.Cancel:
                    multiLineTextMsgBox.Text = "Izabrali ste dugme Cancel";
                    break;
            }
        }
    }
}
