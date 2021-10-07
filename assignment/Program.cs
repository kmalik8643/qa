using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class rectangle
    {   // declaration
        private int length;
        private int width;

        public rectangle()
        {
            length = 1;
            width = 1;
        }

        public rectangle(int L, int W)
        {
            length = L;
            width = W;
        }

        public void setlength(int L)
        {
            length = L;
        }

        public void setwidth(int W)
        {
            width = W;
        }

        public int getlength()
        {
            return length;
        }

        public double getwidth()
        {
            return width;
        }
        // for area
        public int getarea()
        {
            if (length > 0 && width > 0)
            {
                int area;
                area = length * width;
                return area;
            }
            return 0;
            
        }
        // for perimeter
        public int getperimeter()
        {
            if (length > 0 && width > 0)
            {
                int perimeter;
                perimeter = (length + width) * 2;
                return perimeter;
            }
            return 0;
        }

        static void Main(string[] args)
        {

            // obj 1 for default
            rectangle obj1 = new rectangle();
            Console.WriteLine("area:{0}", obj1.getarea());
            Console.WriteLine("perimeter:{0}", obj1.getperimeter());
            rectangle obj2 = new rectangle(10, 8);

            // obj 2 for non default
            Console.WriteLine("area:{0}", obj2.getarea());
            Console.WriteLine("perimeter:{0}", obj2.getperimeter());
            Console.ReadLine();

        }
    }
}

