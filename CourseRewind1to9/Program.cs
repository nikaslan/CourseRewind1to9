using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRewind1to9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            

            int xMin = 30;
            int xMax = 150;
            int yMin = 20;
            int yMax = 90;

            int pX = 100, pY = 70;  string pName = "Point P"; //point P
            int oX = 50, oY = 110;  string oName = "Point O"; //point O
            int uX = 200, uY = 70;  string uName = "Point U";//point U
            int tX = 100, tY = 5;   string tName = "Point T";//point T
            int rX, rY; string rName = "Your point";//point R

            Console.WriteLine("{0} ({1},{2}) - {3}",pName, pX, pY,((pX>xMin && pX<xMax)&&(pY>yMin&&pY<yMax)));
            Console.WriteLine("{0} ({1},{2}) - {3}",oName, oX, oY,((oX>xMin && oX<xMax)&&(oY>yMin&&oY<yMax)));
            Console.WriteLine("{0} ({1},{2}) - {3}", uName, uX, uY, ((uX>xMin && uX<xMax)&&(uY>yMin&&uY<yMax)));
            Console.WriteLine("{0} ({1},{2}) - {3}", tName, tX, tY, ((tX > xMin && tX < xMax) && (tY > yMin && tY < yMax)));

            while (true)
            {
                Console.WriteLine("Enter another point");
                Console.WriteLine("Enter your point X coordinate");
                rX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your point Y coordinate");
                rY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} ({1},{2}) - {3} \n", rName, rX, rY, ((rX > xMin && rX < xMax) && (rY > yMin && rY < yMax)));
                if (Console.ReadKey(true).Key==ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
