using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskEncapsulation
{
    internal class User
    {
        string _name;
        public string Name  { get { return _name; } set {  } } 
       
        string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 8) return;
                //{
                  //  Console.WriteLine("Sifre bosluqlardan ibaret ola bilmez!");
                    //return;
               // }
                //else if (value.Length < 8)
                //{
                //    Console.WriteLine("Sifre 8 herf ve ya reqemden az olmamalidir!");
                //    return ;
                //}
                if (!(CheckPassword(value))) return;
                
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
                if (value > 0)
                {
                    Console.WriteLine("Yasi duzgun daxil et ");
                    return;
                }
                _age = value;   
            }
        
        }
        public User(string name,string password,int age)
        {
            _name = name;
            _password = password;
            _age = age;
        }
        private bool CheckPassword (string password)
        {   
            foreach (char item in password)
            {
                if (char.IsUpper(item))
                {
                    return true;
                }
                {
                 if (char.IsDigit(item))
                    {
                        return true;    
                    }
                }
            }
        return false;
        }
          

      
    }
}
