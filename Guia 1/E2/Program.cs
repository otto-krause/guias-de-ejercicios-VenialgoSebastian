using System;

namespace E2
{
    class mulodiv
    {
        static void Main(string[] args)
        {   int cont=0;
            int n1 = 0;
            int n2 = 0;
            int x = 0 ;
            int multi = 0;
            Console.WriteLine("agrega numero 1 y numero 2");
            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("1 para multiplicacion 2 para division ");
            x = Int32.Parse(Console.ReadLine());
            if(x==1)
            {
                
                for(int i = 0; i < n2; i++)
                {
                    multi = multi + n1;
                }
                Console.WriteLine("la mutliplicacion es ");
            }
            else
            {
                while(n1 >= n2)
                {
                    cont += 1;
                    n1-=n2;
                }
                Console.WriteLine("el resultado de division es:"+cont+" y el resto es: "+n1);
            }

        }
    }
}
