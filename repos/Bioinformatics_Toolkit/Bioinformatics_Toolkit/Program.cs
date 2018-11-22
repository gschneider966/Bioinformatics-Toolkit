using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioinformatics_Toolkit
{
    class Program 
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello.");
            GUI_C GUI = new GUI_C();

            Login now = new Login();

            while  (now.Auth(GUI.USERID, GUI.PASSWORD) != true )
            {
                now.Auth(GUI.USERID, GUI.PASSWORD);
            }
            
            

                System.Console.ReadLine();
            
        }
    }

    
}
