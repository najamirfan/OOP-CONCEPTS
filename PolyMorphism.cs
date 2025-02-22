using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLYMORPHISM
{

    //**********************************************************************
    //Method Overloading
    //same name functions having multiple methods
    /// -> different return type
    /// -> different parameters data types
    
    class maths
    {
        public int ADD(int n1, int n2)
        {
            return (n1 + n2);
        }
        public double ADD(double n1, double n2)
        {
            return (n1 + n2);
        }
        public double ADD(double n1, double n2, double n3)
        {
            return (n1 + n2+n3);
        }

    }
    
    //***********************************************************************
    //Operator Overloading
    class COMPLEX
    {

        public int real, imaginary;

        public COMPLEX(int r, int i)
        {
            real = r;
            imaginary = i;
        }

        public static COMPLEX operator +(COMPLEX c1, COMPLEX c2)
        {
            return(c1 + c2);
        }
        public void display()
        {
            Console.WriteLine($"{real} + {imaginary}i");

        }
    }



    class Program
    {
        static void Main()
        {
            /* ***************************************************
           //method overloading
           maths obj = new maths();
           Console.WriteLine(obj.ADD(2, 5));
           Console.WriteLine(obj.ADD(2.5, 5.3));
           Console.WriteLine(obj.ADD(2, 5, 6));
               */
            //*****************************************************
            //operator overloading
            COMPLEX num1 = new COMPLEX(2, 4);
            COMPLEX num2 = new COMPLEX(3, 5);
            COMPLEX sum = num1 + num2; //operator overload
           
            //****************************************************

        }
    }
}
