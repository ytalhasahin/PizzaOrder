using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_FrmApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result = cbPizza.Text;
            result += "\nMalzemeler\n";
            if(checkMantar.Checked)
                result += checkMantar.Text+" ";
            if(checkZeytin.Checked)
                result += checkZeytin.Text+" ";
            if(checkKasar.Checked)
                result+= checkKasar.Text+" ";

            result +="\nSoğan Durumu\n";
            if(rbSoganli.Checked)
                result += rbSoganli.Text;
            else if(rbSogansiz.Checked)
                result += rbSogansiz.Text;

            rich.Text = result;
        }
    }
}
