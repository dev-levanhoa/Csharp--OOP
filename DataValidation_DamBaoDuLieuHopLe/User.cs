using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation_DamBaoDuLieuHopLe
{
    class User
    {
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if(value.Length >= 6)
                {
                    username = value;
                }
                else
                {
                    Console.WriteLine("Ten dang nhap phai co it nhat 6 ki tu !");
                }
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if(value.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Mat khau phai co it nhat 8 ki tu!");
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public bool CheckPassword(string inputPassword)
        {
            return password == inputPassword;
        }
    }
}
