using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraa_v_p
{
    class Program

        {
            static void Main(string[] args)
            {
                operaciones tt = new operaciones();//creando objeto de nuestra clase donde se encutran todos los metodos
                tt.metodomenu();  //invocando el metodo donde se encuentra menu

            }
        }
    }


    class operaciones//clase la cual contiene todos los metodos
    {
        public int op = 0; //declaracion de variables
        public double v1 = 0, v2 = 0;


        public void metodomenu()//este metodo contiene las opciones a elegir en el menu
        {//apertura del metodo

            do
            {
                Console.Clear();//limpiar pantalla 

                Console.WriteLine("Digite el numero de la operacion a realizar");
                Console.WriteLine("1.Area de un Cuadrado y su perimetro");
                Console.WriteLine("2.Area de un Rectangulo y su perimetro");
                Console.WriteLine("3.Area de un Circulo y su perimetro");
                op = int.Parse(Console.ReadLine());

            } while (op != 1 && op != 2 && op != 3);//mientras que no digite una de las opciones en el menu se repetira

            if (op == 1) { uno(); }//si digiga 1 entonces nos dirigimos al metodo uno
            if (op == 2) { dos(); }//si digiga 2 entonces nos dirigimos al metodo dos
            if (op == 3) { tres(); }//si digiga 3 entonces nos dirigimos al metodo tres

        }//cierre de la clase menu donde nos pide opcion a evaluar


        public void uno()
        {

            Console.Clear();
            Console.WriteLine("Area de un Cuadrado y su perimetro");
            Console.WriteLine("Digite la base");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura");
            v2 = double.Parse(Console.ReadLine());
            double v3 = Math.Pow(v1, 2);

            double v4 = 4 * v1;
            Console.WriteLine("Perimetro del cuadrado: " + v4 + "cm");
            Console.WriteLine("Area del cuadrado: " + v3 + "cm^2");
            continuar();

        }




        public void dos()
        {

            Console.Clear();
            Console.WriteLine("Area de un Rectangulo y su perimetro");
            Console.WriteLine("Digite la base");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la altura");
            v2 = double.Parse(Console.ReadLine());
            double v3 = 2 * (v1 + v2);//perimetro
            double v4 = v2 * v1;//area
            Console.WriteLine("Perimetro del cuadrado: " + v3 + "cm");
            Console.WriteLine("Area del Rectangulo: " + v4 + "cm^2");
            continuar();

        }

        public void tres()
        {
            Console.Clear();
            Console.WriteLine("Area de un Circulo y su perimetro");
            Console.WriteLine("Digite radio del circulo");
            v1 = double.Parse(Console.ReadLine());
            double v3 = 2 * 3.1416 * v1;//perimetro
            double v4 = 3.1416 * (Math.Pow(v1, 2));//area
            Console.WriteLine("Area del Ciruclo: " + v4 + "cm^2");
            Console.WriteLine("Perimetro del Ciruclo: " + v3 + "cm");
            continuar();
        }



        public void continuar()
        {
            char l = 'a';

            while (l == 'a')
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Desea Continuar s=si, n=no");
                l = Convert.ToChar(Console.ReadLine());


                if (l == 's' || l == 'S') { metodomenu(); }//regresamos al menu
                if (l == 'n' || l == 'N')
                {//si digitamos n o N un mensaje de despedida 
                    Console.WriteLine("Adios");
                    l = 'b';
                    Console.ReadKey(true);
                }
                else
                {
                    l = 'a';
                    Console.Clear();
                }//cierre else

            }



        }




    }
