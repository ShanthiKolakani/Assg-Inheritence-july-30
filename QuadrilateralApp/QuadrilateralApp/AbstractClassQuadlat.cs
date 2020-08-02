using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadrilateralApp;

namespace QuadrilateralApp
{
    abstract class Quadrilateral

    {
        public int isSquare;
        public int area;
      public int LengthOfSquare = 4;
    public int LengthOfRec = 5;
    public  int BreathOfRec = 6;
        public Quadrilateral()
        {

        }
        public Quadrilateral(int _lengthOfSquare)
        {
            _lengthOfSquare = LengthOfSquare;
        }
        public Quadrilateral(int _lengthOfRec, int _breathOfRec)
        {

            _lengthOfRec = LengthOfRec;
            _breathOfRec = BreathOfRec;

        }

        public void Display()
        {

        }
        public abstract string ShowArea();



    }

    class Square : Quadrilateral
    {
        public Square()
        {

        }
        public Square(int _lengthOfSqu) : base(_lengthOfSqu)
        {

        }

        public int Area(int _lengthOfSquare)
        {
            area = _lengthOfSquare;
            return area;
        }

        public override string ShowArea()
        {
            return "Square is greater than Rectangle area";
        }

    }

    class Rectangle : Quadrilateral
    {
        public Rectangle()
        {

        }
        public Rectangle(int _lengthOfRec, int _breathOfRec) : base(_lengthOfRec, _breathOfRec)
        {
            BreathOfRec = _breathOfRec;
        }

        public int IsSquare
        {
            get { return BreathOfRec; }
            set
            {
                if(value == LengthOfRec)
                {
                    Console.WriteLine("It is a Square");
                }
                else
                {
                    BreathOfRec = value;
                }

            }
        }
        public int Area(int _lengthOfRec, int _breathOfRec)
        {
            area = _lengthOfRec * _breathOfRec;
            return area;
        }
        public override string ShowArea()
        {

            return "Rectangle is greater";
        }


    }


    class AbstractClassQuadlat
    {
        static void Main()
        {
            Quadrilateral r = new Rectangle();
            r.area = Convert.ToInt32(Console.ReadLine());
            r.ShowArea();
            r.Display();

           
            Quadrilateral s = new Square();
            s.area = Convert.ToInt32(Console.ReadLine());
            r.ShowArea();
            r.Display();

            Rectangle i = new Rectangle();
           

            /*f (s.area > r.area)
             {
                 Console.WriteLine("Square is greater than Rectangle area");
             }
             else {
                 Console.WriteLine("Rectangle is greater than Square");
             }
            */
            Console.WriteLine("{0} {1}", r.area, s.area);
            Console.Read();
            
            
            
       
        }
    }
}
