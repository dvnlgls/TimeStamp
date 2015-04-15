using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetTimeStamp();
        }

        private void GetTimeStamp()
        {
            lblMessage.Visible = false;
            lblResult.Visible = false;

            try
            {
                //default separator
                string Separator = "_";

                if (!string.IsNullOrEmpty(txtSeparator.Text))
                    Separator = txtSeparator.Text;

                DateTime dt = DateTime.Now;

                string[] TimeStamp = new string[6];

                TimeStamp[0] = dt.Year.ToString();
                TimeStamp[1] = dt.ToString("MM");
                TimeStamp[2] = dt.ToString("dd");
                TimeStamp[3] = dt.ToString("HH");
                TimeStamp[4] = dt.ToString("mm");
                TimeStamp[5] = dt.ToString("ss");

                string Result = string.Join(Separator, TimeStamp);
                Clipboard.SetText(Result);

                lblMessage.Text = "Time Stamp copied to clipboard!";
                lblResult.Text = Result;
            }
            catch
            {
                lblMessage.Text = "Error! Please try again";
                lblResult.Text = "";
            }

            lblMessage.Visible = true;
            lblResult.Visible = true;
        }

        private void btnCopyTS_Click(object sender, EventArgs e)
        {
            GetTimeStamp();
        }


    }
}
