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



            string sLine = "";
            string[] ins = new string[2];
            string[] line = null;
            double vEsperado = 0;
            int[] vEntrada = null;
            ArrayList arrText = new ArrayList();

            try
            {
                StreamReader reader = new StreamReader(@"C:\CasosPrueba.txt");
                while (sLine != null)
                {
                    sLine = reader.ReadLine();
                    line = sLine.Split(':');
                    try
                    {
                        if (line[2] == null)
                        {
                            Console.WriteLine("Entrada Nula");
                        }

                        ins[0] = line[2];
                        ins[1] = line[3];
                        string c = ins[0];
                        string c2 = ins[1];
                        vEsperado = double.Parse(c2);

                        ins = new string[c.Length];
                        ins = c.Split(' ');
                        Console.WriteLine("______________________________________________");
                        vEntrada = new int[ins.Length];

                        for (int i = 0; i <= ins.Length - 1; i++)
                        {
                            vEntrada[i] = int.Parse(ins[i]);

                        }

                        if (line[1] == "mediaAritmetica")
                        {
                            double x = Media.MediaAritmetica(vEntrada);
                            if (x == vEsperado)
                            {
                                Console.WriteLine("Prueba"+line[0]+"Prueba Exitosa" + "\n", Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Prueba Fallida" + "\n", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ResetColor();
                            }
                        }
                        //else if (parts[1] == "raizEnesima")
                        //{
                        //}
                        else if (line[1] == "mediaArmonica")
                        {
                            double x = Media.mediaArmonica(vEntrada);
                            if (x == vEsperado)
                            {
                                Console.WriteLine("Prueba Exitosa" + "\n", Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Prueba Fallida" + "\n", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ResetColor();
                            }
                        }
                        else if (line[1] == "mediaGeomatrica")
                        {
                            Media media = new Media();
                            double x = media.mediaGeometrica(vEntrada);
                            if (x == vEsperado)
                            {
                                Console.WriteLine("Prueba Exitosa" + "\n", Console.ForegroundColor = ConsoleColor.Green);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Prueba Fallida" + "\n", Console.ForegroundColor = ConsoleColor.Red);
                                Console.ResetColor();
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Fallo" + "\n", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        Console.WriteLine("___________________________________________");
                    }
                }
                reader.Close();

                foreach (string sOutput in arrText)
                Console.WriteLine(sOutput);
                Console.ReadLine();
            }
            catch(Exception e)
            {

            }

            Console.ReadLine();

        }
    }
}
