using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public class Panda
        {
            public string Name;
            public static int Population;

            public Panda(string n)
            {
                Name = n;
                Population = Population + 1;
            }
        } 

        public struct Point
        {
            public int x, y;
        }

        public class PointRef
        {
            public int x, y;
        }

        static void Main(string[] args)
        {

            //STATIC EXAPLE
            Panda p1 = new Panda("Panda1");
            Panda p2 = new Panda("Panda2");
            p1.Name = "Nikola"; //promenice samo ime vec postojece p1 pande

            Console.WriteLine("panda1 name:" + p1.Name);
            Console.WriteLine("panda2 name: " + p2.Name);

            Console.WriteLine("panda population: " + Panda.Population);
            Console.WriteLine();

            //VALUE AND REFERENCE TYPES
            //value types
            Point po1 = new Point();
            po1.x = 7;
            Point po2 = po1;

            Console.WriteLine("po1.x: " + po1.x);
            Console.WriteLine("po2.x" + po2.x);

            po1.x = 9;

            Console.WriteLine("po1.x: " + po1.x);
            Console.WriteLine("po2.x" + po2.x);
            Console.WriteLine();

            //reference types

            PointRef po1Ref = new PointRef();
            po1Ref.x = 7;

            PointRef po2Ref = po1Ref;

            Console.WriteLine("po1Ref.x: " + po1Ref.x);
            Console.WriteLine("po2Ref.x: " + po2Ref.x);

            po1Ref.x = 9;

            Console.WriteLine("po1Ref.x: " + po1Ref.x);
            Console.WriteLine("po2Ref.x: " + po2Ref.x);


            Console.ReadLine();
        }
    }
}
