using System;

namespace POO {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Por Favor, digite o dia da semana:");
            string strDiasDaSemana = Console.ReadLine();
            int diaDaSemana=Convert.ToInt32(strDiasDaSemana);
            switch (diaDaSemana) {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("Dia da semana inválido");
                    break;

            }

        }
    }
}