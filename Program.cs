using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();

            // 1° opção sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular() );

            // 2° opção, com 1 argumento
            System.Console.WriteLine( infoPlayer.Calcular(350) );

            // 3° opção com 2 argumentos
            System.Console.WriteLine( infoPlayer.Calcular(350, 74) );

            // 4° opção sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular("Jean", "Grey") );


        }
    }
}
