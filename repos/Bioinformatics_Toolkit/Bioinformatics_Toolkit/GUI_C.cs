using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioinformatics_Toolkit
{
    public class GUI_C
    {
        public GUI_C()
        {
            Console.WriteLine("Welcome to Bioinformatics Toolkit v0.01");
            Console.WriteLine("UserID: ");
            USERID = Console.ReadLine();
            Console.WriteLine("PASSWORD: ");
            PASSWORD = Console.ReadLine();

        }

        public string USERID;
        public string PASSWORD;

        
        

    }
}
