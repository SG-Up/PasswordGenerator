using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Media;
using System.Resources;
using System.Reflection;




namespace PwdGen
{
    public partial class form1 : Form
    {
        
        
        public form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

             
            SoundPlayer simpleSound = new SoundPlayer(PwdGen.Properties.Resources.background1);
            simpleSound.Play();

        }
        private void bttnGenerate_Click(object sender, EventArgs e)
        {
            int passLength = Convert.ToInt32(txtPassLength.Text);
            

            if (passLength < 8 || passLength > 25)
            {
                txtPass.Text = "Please enter a number between 8 and 25";
            }

            else if (chkSpChar.Checked == true)
            {
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
                StringBuilder res = new StringBuilder();
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                {
                    byte[] uintBuffer = new byte[sizeof(uint)];

                    while (passLength-- > 0)
                    {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        res.Append(valid[(int)(num % (uint)valid.Length)]);
                    }
                }
                txtPass.Text = res.ToString();

            }

            else
            {
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                StringBuilder res = new StringBuilder();
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                {
                    byte[] uintBuffer = new byte[sizeof(uint)];

                    while (passLength-- > 0)
                    {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        res.Append(valid[(int)(num % (uint)valid.Length)]);
                    }
                }
                txtPass.Text = res.ToString();
            }
        }
        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void bttnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPass.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(PwdGen.Properties.Resources.background1);
            simpleSound.Play();

            if (chkMusic.Checked == true)
            {
                simpleSound.Stop();
            }
            else
            {
                simpleSound.Play();
            }
        }

        private void txtPassLength_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassLength_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtPassLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number");
            }
        }
    }

   
}
