using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace aesEncryptionDecryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Chilkat.Crypt2 encrypt = new Chilkat.Crypt2
                {
                    CryptAlgorithm = "aes",
                    CipherMode = "ctr",
                    KeyLength = 256,
                    EncodingMode = "base64"
                };

                string keyHex = keyField.Text;
                encrypt.SetEncodedKey(keyHex, "ascii");
                string ivHex = vectorField.Text;
                encrypt.SetEncodedIV(ivHex, "ascii");
                string encStr = encrypt.EncryptStringENC(inputField.Text);
                outputField.Text = encStr;
            }
            else
                if (radioButton2.Checked)
                {
                    string iv = vectorField.Text;
                    string key = keyField.Text;

                    Chilkat.Crypt2 decrypt = new Chilkat.Crypt2
                    {
                        CryptAlgorithm = "aes",
                        CipherMode = "ctr",
                        KeyLength = 256,
                        EncodingMode = "base64"
                    };

                    decrypt.SetEncodedIV(iv, "ascii");
                    decrypt.SetEncodedKey(key, "ascii");
                    string decStr = decrypt.DecryptStringENC(inputField.Text);
                    outputField.Text = decStr;
                }
        }
    }
}
