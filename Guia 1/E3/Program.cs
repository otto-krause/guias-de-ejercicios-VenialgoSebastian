using System;

namespace E3
{
    class ingreso
    {
        static void Main(string[] args)
        {   
            int n1= 0;
            Console.WriteLine("ingresa un numero ");
            n1 = Int32.Parse(Console.ReadLine());
            par(n1);
            primo(n1);
        }
        
        static public void par(int n1)
        {
            
            
            if (n1 % 2 == 0)
            {
                Console.WriteLine("su numero es par");
            }
            else 
            {
               Console.WriteLine("su numero es inpar");
            }
        }

        static public void primo(int n1)
        {
            int n=2;
            bool band=true;
            while( (band) &&(n <n1))
            {
                if((n1%n)==0)
                {
                    band=false;
                }
                else 
                {
                    n=n+1;
                }
            }
            if(band)
            {
                Console.Write("es primo");
            }
            else
            {
                Console.Write("no es primo");
            }
        }
    }
}