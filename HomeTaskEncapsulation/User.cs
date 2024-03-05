using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskEncapsulation
{
    internal class User
    {
        string _name;
        string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Sifre bosluqlardan ibaret ola bilmez!");
                    return;
                }
                else if (value.Length < 8)
                {
                    Console.WriteLine("Sifre 8 herf ve ya reqemden az olmamalidir!");
                    return ;
                }
                _password = value;
                
            }

        } 
        int _age;

        public int Age  { 
            
            get
            {
                return _age; 
            }
            
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yasi duzgun daxil et ");
                    return;
                }
                _age = value;   
            }
        
        }
    }
}
