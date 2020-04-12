using System;

namespace E1
{
    class num
    {
        static void Main(string[] args)
        {
            int[] vector = new int [10];
            int aux = 0 ; 
            int suma = 0 ;
            double prome = 0 ; 
            int menor = 0 ; 
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                vector[i] = Int32.Parse(Console.ReadLine());
                suma += vector[i];
                
                if( vector[i]<menor || menor == 0)
                {
                    menor = vector[i];
                }
            }
            
            prome = suma/10;
            Console.WriteLine("la suma es: " + suma +"\n el promedio es :"+ prome +"\n el numero menor es:"+menor);
            for (int i = 0; i < 10; i++)
            {

                for (int j = 10-1; j >= i; j--)
                {

                    if (vector[j] > vector[i])
                    {

                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                        
                    }

                }

            }
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
