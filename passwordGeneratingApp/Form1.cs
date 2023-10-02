using System.Text;
using System;

namespace passwordGeneratingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnGenerating_Click(object sender, EventArgs e)
        {
            CheckBox checkingItem = new CheckBox();
            List<string> checkBoxChecked = new List<string>();

            foreach (Control item in groupBox1.Controls)
            {
                if(item is CheckBox)
                {
                   checkingItem = (CheckBox)item;
                         if(checkingItem.Checked)
                    {
                        checkBoxChecked.Add(checkingItem.Text);
                    }                         
                }                
            }
            if(numericPasswordLength.Size.Width < 3 || numericPasswordNumber.Size.Width <1)
            {
                MessageBox.Show("oluþturmak istediðiniz þifre sayýsý 1 den küçük 20' dan büyük ve þifre uzunluðu 3 ten kuçuk olamaz\n lütfen tekrar giriniz.\n");
            }
            else if (checkBoxChecked.Count == 0)
            {
                MessageBox.Show("lütfen en az bir adet checkleyin.");

            }
            else 
            {
                int passwordNumber = (int) numericPasswordNumber.Value;
                int passwordLength = (int)numericPasswordLength.Value;
                Random rnd = new Random();
                string characters = "";
                foreach(string checkBox in checkBoxChecked)
                {                    
                    if(checkBox == chcLowerLetter.Text)
                    {
                        characters = "abcdefghijklmnopqrstuvwxyz";
                    }
                    if (checkBox == chcUpperLetter.Text)
                    {
                        characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    }
                    if (checkBox == chcSpecialCharacter.Text)
                    {
                        characters += "!@#$%^&*()_+";
                    }
                    if(checkBox==chcNumber.Text)
                    {
                        characters += "0123456789";
                    }
                }

                StringBuilder passwordBuilder = new StringBuilder();

                
                for(int i= 0; i<passwordNumber; i++)
                {
                    for (int k = 0; i < passwordLength; k++)
                    {
                        int randomIndex = rnd.Next(0, characters.Length);
                        char randomChar = characters[randomIndex];
                        passwordBuilder.Append(randomChar);
                    }
                    passwordBuilder.Append(Environment.NewLine);


                }
                listBox1.Items.Add(passwordBuilder.ToString());
            }

        }
    }
}