using System;
using Cadastros;

namespace System.Collections.Generic {
    namespace POO {
        class Program {
            static void Main(string[] args) {

                Pessoa pessoa1 = new Pessoa();
                Pessoa pessoa2 = new Pessoa("Paulo", "Ponciano", Convert.ToDateTime("1989-11-22"));
                Console.WriteLine("O nome da pessoa é: " + pessoa2.Nome);
                Console.WriteLine("A data de nascimento da pessoa é: " + pessoa2.DataNascimento.ToString("dd/MM/yyyy"));
                List < Pessoa > listaPessoa = new List < Pessoa > ();

                Console.WriteLine("Digite a quantidade de pessoas que deseja adicionar:");
                int quantidadePessoas = 0;
                try {
                    quantidadePessoas = Convert.ToInt32(Console.ReadLine());
                } catch (Exception ex) {
                    Console.WriteLine("Valor digitado inválido. " + ex.Message);
                }

                if (quantidadePessoas > 0) {
                    for (int i = 0; i < quantidadePessoas; i++) {
                        Pessoa objpessoa = new Pessoa();
                        Console.WriteLine("Digite o nome da pessoa:");
                        objpessoa.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome da pessoa:");
                        objpessoa.Sobrenome = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento da pessoa:");
                        objpessoa.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                        listaPessoa.Add(objpessoa);
                    }

                    Console.WriteLine("Pessoas armazenadas: " + listaPessoa.Count);

                    foreach(var item in listaPessoa) {
                        Console.WriteLine("O nome da pessoa é: " + item.Nome + ". O sobrenome da pessoa é: " + item.Sobrenome + ". A data de nascimento da pessoa é: " + item.DataNascimento.ToString("dd/MM/yyyy"));
                    }
                }


                //switch case
                // Console.WriteLine("Por Favor, digite o dia da semana:");
                // string strDiasDaSemana = Console.ReadLine();
                // int diaDaSemana = Convert.ToInt32(strDiasDaSemana);
                // switch (diaDaSemana) {
                //     case 1:
                //         Console.WriteLine("Domingo");
                //         break;
                //     case 2:
                //         Console.WriteLine("Segunda-feira");
                //         break;
                //     case 3:
                //         Console.WriteLine("Terça-feira");
                //         break;
                //     case 4:
                //         Console.WriteLine("Quarta-feira");
                //         break;
                //     case 5:
                //         Console.WriteLine("Quinta-feira");
                //         break;
                //     case 6:
                //         Console.WriteLine("Sexta-feira");
                //         break;
                //     case 7:
                //         Console.WriteLine("Sábado");
                //         break;

                //     default:
                //         Console.WriteLine("Dia da semana inválido");
                //         break;
                // }

            }
        }
    }
}