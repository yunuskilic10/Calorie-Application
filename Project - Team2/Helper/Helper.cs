using DevExpress.XtraEditors;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project___Team2.Helper
{
    internal static class Helper
    {
        public static bool AreTextBoxesEmpty(Form form)
        {
            bool IsEmpty = false;
            foreach (var item in form.Controls)
            {
                if (item is Guna2TextBox txt)
                    if (txt.Text == "")
                        IsEmpty = true;
                if (item is TextEdit txt1)
                    if(txt1.Text == "")
                        IsEmpty = true;
            }
            return IsEmpty;
        }

        public static void ClearTextBoxes(Form form)
        {
            foreach (var item in form.Controls)
                if (item is TextBox txt)
                    txt.Text = null;
                else if(item is Guna2TextBox txt1)
                {
                    txt1.Text = null;   
                }
        }

        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        public static bool PasswordControl(string sifre)
        {
            // Şifrenin uzunluğunun en az 8 karakter olması gerekiyor
            if (sifre.Length < 8)
            {
                return false;
            }

            int numberOfUpper = 0;
            int numberofLower = 0;
            int numberofNumber = 0;

            // Şifrenin her bir karakterini dolaşarak büyük harf, küçük harf ve özel karakter sayılarını hesaplıyoruz
            foreach (char c in sifre)
            {
                if (Char.IsUpper(c))
                {
                    numberOfUpper++;
                }
                else if (Char.IsLower(c))
                {
                    numberofLower++;
                }
                else if (c == '!' || c == ':' || c == '+' || c == '*')
                {
                    numberofNumber++;
                }
            }

            // Şifrenin en az 2 büyük harf, en az 3 küçük harf ve en az 2 özel karakter içermesi gerekiyor
            if (numberOfUpper < 2 || numberofLower < 3 || numberofNumber < 2)
            {
                return false;
            }
            // Eğer tüm kurallar sağlanıyorsa, şifre doğru kabul edilir
            return true;
        }

        public static bool MailControl(string mail)
        {
            if (mail.EndsWith("@gmail.com") || mail.EndsWith("@hotmail.com"))
                return true;
            return false;
        
        }

        


    }
}
