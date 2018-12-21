using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.coddingschool.System.IO
{

    class Program
    {
        static void FindDirectos(String FDir)
        {
            try
            {


                foreach (var Fil in Directory.GetDirectories(FDir))
                {
                    if (Directory.GetFiles(FDir) != null)
                    {
                        foreach (var File in Directory.GetDirectories(Fil))
                        {

                            Console.WriteLine(Fil);
                        }

                    }
                    Console.WriteLine(Fil);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Main(string[] args)
        {

            var info = Directory.GetDirectories(@"C:\");
            foreach (var item in info)
            {
                try
                {
                    if (Directory.GetDirectories(item) != null)
                    {


                        foreach (var Infofile in Directory.GetDirectories(item))
                        {
                            Console.WriteLine(Infofile);
                            FindDirectos(Infofile);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(item);
                FindDirectos(item);
            }

          

        }

    }
}

