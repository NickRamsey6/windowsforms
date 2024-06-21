using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rot13Encoder
{
    public partial class Form1 : Form
    {
        // Encryption method
        public string ROT13(string input)
        {
            // Create dynamic string object
            StringBuilder result = new StringBuilder();
            // Set regex pattern to only A-Z letters, upper or lowercase
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in input)
            {
                // If the character in the input text matches the regex we will cypher it
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                // If the character in the input text is not found in the regex we will return it as is
                else
                    result.Append(c);
            }
            return result.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Text = ROT13(inputBox.Text);
        }
    }
}
