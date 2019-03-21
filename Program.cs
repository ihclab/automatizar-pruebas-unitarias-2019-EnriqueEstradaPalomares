using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasUnitarias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque el archivo CasosPrueba en C:");
            Console.ReadLine();
            Console.Clear();
            StreamReader reader = new StreamReader(@"C:\CasosPrueba.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = reader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            reader.Close();

            foreach (string sOutput in arrText)
            Console.WriteLine(sOutput);
            Console.ReadLine();
        }
    }
}
