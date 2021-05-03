using System;
using System.Collections.Generic;


namespace HerenciaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Polimorfismo paramétrico
            ///Mala idea
            DatoInt di = new DatoInt(1);
            Console.WriteLine(di.getValor());
            DatoDbl dd = new DatoDbl(2.1);
            Console.WriteLine(dd.getValor());
            //FIN mala idea

            //Buena idea
            Dato<int> dint = new Dato<int>(2);//Se asigna el tipo de la variable
            Console.WriteLine(dint.getValor());
            Dato<string> ds = new Dato<string>("Hola");
            Console.WriteLine(ds.getValor());
            Dato<double> ddo = new Dato<double>(3.14);
            Console.WriteLine(ddo.getValor());
            //FIN buena idea            
            //FIN Polimorfismo paramétrico


             TestHumanos();
             TestExtraterrestres();

       

            Console.Write("\n\n\nPress any key to exit ...");
            Console.ReadKey();

        }// end Main

    

                static void TestHumanos() {

                    Humano Batman = new Humano("Bruce Wayne", "Batman");
                    Humano CanarioNegro = new Humano(" Dinah Drake", "Canario Negro");
                    Console.WriteLine(Batman.Ataca());



                }//end TestHumans

                static void TestExtraterrestres(){
                    Extraterrestre Superman = new Extraterrestre("Clark Kent", "Superman", new List<SuperPoder>{SuperPoder.SuperFuerza, SuperPoder.SuperVelocidad}, "Krypton");
                    Console.WriteLine(Superman.Ataca());
                }
    }
}
        


    