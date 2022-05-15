using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace string_handling
{
    public partial class Form1 : Form
    {
        public int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtboxInput.Text;

            richOutput.Text = input.Length.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            string input = txtboxInput.Text;
            string rev = reverseString(input);
            richOutput.Text = (input == rev) ? "Is a palindrome":"Is not a Palindrome";
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string input = txtboxInput.Text;
            input = reverseString(input);
            richOutput.Text = input;
        }

        private string reverseString(string data)
        {
            string rev = "";

            for (int i = data.Length-1; i > -1; i--)
            {
                rev += data[i]; 
            }

            return rev;
        }

        private void btnWords_Click(object sender, EventArgs e)
        {
            string input = txtboxInput.Text;
            int count = 1;

            if (txtboxInput.Text == "")
            {
                count = 0;
            }
            else
            {

                foreach (var item in input)
                {
                    if (item == ' ')
                    {
                        count++;
                    }
                }
            }

            richOutput.Text = $"Number of words are {count}";

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string input = txtboxInput.Text;
           input = Encryption.Encrypt(input);
            richOutput.Text = input;
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string input = txtboxInput.Text;

           input = Encryption.Decrypt(input);
            richOutput.Text = input;
            
        }

        private void btnASCII_Click(object sender, EventArgs e)
        {
            richOutput.Clear();
            string input = txtboxInput.Text.ToUpper();
            string output = "";
            if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            { 
                foreach (var c in input)
                {
                    output += $"{((int)c - 64).ToString()}-";
                }
                output = output.Remove(output.Length - 1, 1);
                richOutput.Text = output; 
            }
            else
            {
                  MessageBox.Show("Please input only letters from the alphabets, no numbers or special characters");
            }
            
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            richOutput.Clear();
            try
            {
                int input = Convert.ToInt32(txtboxInput.Text.ToUpper());


                while (input > 26)
                {
                    input -= 26;
                }
                input += 64;

                richOutput.Text += ((char)input).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please only input numbers, no letters");
                 
            }
            

            
                
            
        }

        private void btnEachline_Click(object sender, EventArgs e)
        {
            richOutput.Clear();
            string input = txtboxInput.Text;

            foreach (var item in input)
            {
                richOutput.Text += $"{item}\n";
            }
        }

        private void BtnWarning_Click(object sender, EventArgs e)
        {
           
            Point ButtonOriginal = new Point(716, 220);
            Point newPosition = new Point(20, 180);
            Point labelOriginal = new Point(393, 21);
            Point randomPosition = new Point(39, 388);
            string output = "";
            txtboxInput.Hide();
            btnASCII.Hide();
            btnCharacters.Hide();
            btnDecrypt.Hide();
            btnEachline.Hide();
            btnEncrypt.Hide();
            btnLetter.Hide();
            btnPalindrome.Hide();
            btnReverse.Hide();
            btnWords.Hide();
            richOutput.Hide();
            lbl1.Location = newPosition;

            switch (count)
            {
                case 0:
                    output = "You were warned. Everything has been destroyed by you.";
                    break;
                case 1:
                    output = "Pressing this again won't help";
                    break;
                case 2:
                    output = "Exit and enter the application again please";
                    break;
                case 3:
                    output = "Avid button pressing skills I see?";
                    break;
                case 4:
                    output = "Try to press me now";
                    BtnWarning.Location= randomPosition;
                    break;
                case 5:
                    output = "You should really do something more productive";
                    BtnWarning.Location = new Point(Top);
                    break;
                case 6:
                    output = "Pushing buttons is not a good skill to have, especially with people";
                    BtnWarning.Location = new Point(456,321);
                    break;
                case 7:
                    output = "Are you bored yet?";
                    BtnWarning.Location = new Point(156, 121);
                    break;
                case 8:
                    output = "Your relentlessness has awarded you with the power to restore everything. Click me again";
                    BtnWarning.Location = new Point(Bottom);
                    break;
                case 9:
                    output = "String Handling";
                    txtboxInput.Show();
                    btnASCII.Show();
                    btnCharacters.Show();
                    btnDecrypt.Show();
                    btnEachline.Show();
                    btnEncrypt.Show();
                    btnLetter.Show();
                    btnPalindrome.Show();
                    btnReverse.Show();
                    btnWords.Show();
                    richOutput.Show();
                    lbl1.Location = labelOriginal;
                    BtnWarning.Location = ButtonOriginal;
                    BtnWarning.Text = "Use the other buttons.";
                    count = -1;
                    break;
                default:
                    break;
            }

            lbl1.Text = output;
            count++;
        }
    }
    
}