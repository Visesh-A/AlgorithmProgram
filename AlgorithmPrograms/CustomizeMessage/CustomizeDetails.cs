using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.CustomizeMessage
{
    public class CustomizeDetails
    {
        public void Customize()
        {
            string line = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxx. Today's Date <<date>>.";
            line = line.Replace("<<name>>", "Visesh");
            line = line.Replace("<<full name>>", "A");
            line = line.Replace("91-xxxxxxxxx", "91-987654321");
            line = line.Replace("<<date>>", "25/03/2023");
            Console.WriteLine(line);
        }

    }
}