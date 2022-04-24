using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sec3LabExam_Joplin
{
    public partial class DecoderWheel : Form
    {
        public DecoderWheel()
        {
            InitializeComponent();
        }

        public string cipher(string msg)
        {
            string cMsg = "";

            string[] lAlpha = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] cAlpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] kLower = { "e", "n", "v", "o", "c", "w", "d", "i", "y", "b", "l", "m", "t", "f", "a", "u", "j", "k", "z", "p", "g", "r", "h", "q", "x", "s" };
            string[] kAlpha = { "E", "N", "V", "O", "C", "W", "D", "I", "Y", "B", "L", "M", "T", "F", "A", "U", "J", "K", "Z", "P", "G", "R", "H", "Q", "X", "S" };

            if (rEncrypt.Checked == true)
            {
                foreach (char c in msg)
                {
                    int cNum = 0;
                    string cStr = Convert.ToString(c);

                    while (cNum < 25)
                    {
                        if (cStr == cAlpha[cNum] || cStr == lAlpha[cNum])
                        {
                            cMsg += kAlpha[cNum];
                            break;
                        }
                        else
                        {
                            cNum += 1;
                        }
                    }
                        if (cNum == 25)
                        {
                            cMsg += cStr;
                        }
                    else { }
                }
            }
            else
            {
                foreach (char c in msg)
                {
                    int cNum = 0;
                    string cStr = Convert.ToString(c);

                    while (cNum < 26)
                    {
                        if (cStr == kLower[cNum] || cStr == kAlpha[cNum])
                        {
                            cMsg += cAlpha[cNum];
                            break;
                        }
                        else
                        {
                            cNum += 1;
                        }
                    }
                    if (cNum == 26)
                    {
                        cMsg += cStr;
                    }
                    else { }

                }
            }
            return cMsg;
        }

        int counter = 0;

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string msg = cInput.Text;
            string convert = "";

            if (msg == "")
            {
                convert = "Please enter text in the right hand box!";
            }
            else
            {
                if (rDecrypt.Checked == true || rEncrypt.Checked == true)
                {
                    counter += 1;
                    convert = cipher(msg);
                }
                else
                {
                    convert = "Please select either the encrypt or decrypt radio button!";
                }
            }
            txtMsg.Text = convert;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "";
            cInput.Text = "";
            rEncrypt.Checked = false;
            rDecrypt.Checked = false;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "You converted " + counter + " message(s) this session!";
            txtMsg.Update();

            int timer = 0;

            while (timer < 2000000000)
            {
                timer++;
            }
            this.Close();
        }
    }
}
