

using System.Net.Http.Headers;

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
                if (string.IsNullOrEmpty(value) && value.Length < 8) return;
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
        public User(string name,string password)
        {
            _name=name;
            Password = password;
            
        }
        
        
        
        private bool CheckPassword (string password)
        {
            bool isUpper = false;
            bool isDigit = false;
            foreach (char item in password)
            {  
                if (char.IsUpper(item))
                {
                    isUpper =true;
                }
                {
                 if (char.IsDigit(item))
                    {
                        isDigit = true;    
                    }
                }
            }
        return isUpper&&isDigit ;
        }
          

      
    }
}
