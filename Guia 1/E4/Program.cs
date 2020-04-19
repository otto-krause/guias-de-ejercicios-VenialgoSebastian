using System;

namespace E4
{
    class gato
    {
        static void  Main()
        {
            string nombre="Mad";
            bool vacuna=true;
            int energia=20;
            Menu(nombre , vacuna , energia);
        }
        static void Menu(string nombre, bool vacuna , int energia)
        {
            int min=0;
            int x=0;
            while(x!=6)
            {
                Console.WriteLine("\n-1 mostrar nombre de gatito \n-2 mostrar si esta vacunado \n-3 para que juegue el gatito \n-4 para que coma el gatito \n-5 para saber el estado del gatito \n-6 para salir de menu");
                x= int.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1:
                    mnombre(nombre);
                    break;
                    case 2:
                    mvacuna(vacuna);
                    break;
                    case 3:
                    Console.WriteLine("ingrese minutos de juego");
                    min= Int32.Parse(Console.ReadLine());
                    juego(energia,min);
                    break;
                    case 4:
                    comer(energia);
                    break;
                    case 5:
                    estado(energia,vacuna);
                    break;
                }
            }
        }

        static public void mnombre(string nombre )
        {
            Console.WriteLine("El nombre del gatito es:"+nombre);
        }
        static public void mvacuna(bool vacuna)
        {
            Console.WriteLine("El estado de las vacunas del gatito es:"+vacuna);
        }
        static public int juego(int energia , int min)
        {
            energia=energia-(min*2);
            Console.Write("La energia actual es"+energia);
            return energia;
        }
        static public int comer(int energia)
        {
            energia=energia+50;
             Console.Write("La energia actual es"+energia);
            return energia;
        }
        static public void estado(int energia , bool vacuna)
        {
            if(vacuna==true && energia>30)
            {
                Console.Write("El gatito esta en un buen estado");
            }
            else
            {
                Console.Write("el gatito esta en un mal estado por la energia"+energia+"o por la vacuna:"+vacuna);
            }
        }
    }
}