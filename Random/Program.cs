using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ISTC.ThirdStage.Advance.GC.GC05

{

    class Program

    {

        static void Main(string[] args)

        {
           
                Random random = new Random();
                List<Double> list = new List<double>();
                int maximum = 900000000;
                int split = 100000;
                
                    for (int count = 1; count <= maximum; count++)
                    {
                        list.Add(random.NextDouble());
                        if (count % split == 0)
                        {
                        Console.WriteLine ($"Total item count: {count}.");
                        }
                    }
        }
    }

}