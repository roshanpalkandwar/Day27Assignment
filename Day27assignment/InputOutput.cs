using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27assignment
{
    public class InputOutput
    {
        public void Read(string path)
        {
            using (StreamReader sw = File.OpenText(path))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
        }
        public void Write(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("FirstName   : Roshan");
                sw.WriteLine("LastName    : Palkandwar");
                sw.WriteLine("Address     : 12 utam Nagar");
                sw.WriteLine("PhoneNumber : 1234567890");
                sw.WriteLine("City        : Nagapur");
                sw.WriteLine("State       : Maharashtra ");
                sw.WriteLine("Zip         : 345678");
                sw.WriteLine("Email       : rosh@gmail.com");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
