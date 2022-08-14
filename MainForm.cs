using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waibibaboWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            string encoded=MyEncode.EncodeText(SourceTextBox.Text);
            ResultTextBox.Text = encoded;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            if (!SourceTextBox.Text.EndsWith("卜")&&SourceTextBox.Text.Length!=0)
            {
                MessageBox.Show("密文不对的说", "警告", MessageBoxButtons.OK);
                return;
            }
            HashSet<char> waiBiBaBo = new HashSet<char>() { '歪', '比', '吧', '卜' };
            if (SourceTextBox.Text.ToHashSet<char>().IsSubsetOf(waiBiBaBo))
            {
                ResultTextBox.Text=MyDecode.DecodeText(SourceTextBox.Text);
            }
            else
            {
                MessageBox.Show("密文不对的说", "警告", MessageBoxButtons.OK);
            }
        }
    }
}
