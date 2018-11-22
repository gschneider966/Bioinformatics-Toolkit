using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioinformatics_Toolkit
{
    class Login : GUI_C
    {





        public Login()
        {
                      
        }

        public bool Auth(string A, string B)
        {
            string UI = A;
            string PA = B;
            Dictionary<string, string> UA = new Dictionary<string, string>
            {
                { "bob", "123" },
                { "Sue", "Abc" }
            };


            if (UI == "bob" && UA.ContainsKey("123"))
            {
              
                    return true;
              
            }
            else
            { 
                return false;
            }
        }
    }
}
