using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation_DamBaoDuLieuHopLe
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            do
            {
                Console.Write("Ten dang nhap : ");
                username = Console.ReadLine();
                if (username.Length < 6) Console.WriteLine("Nhap lại !");
            } while (username.Length < 6);
            do
            {
                Console.Write("Mat khau : ");
                password = Console.ReadLine();
                if (password.Length < 8) Console.WriteLine("Nhap lai!");
            } while (password.Length < 8);
            User user1 = new User(username, password);
            Console.WriteLine("Ten dang nhap : " + user1.Username);
            if(user1.CheckPassword(password))
                Console.WriteLine("Mat Khau dung !");
            else
                Console.WriteLine("Mat khau sai !");
        }
    }
}
