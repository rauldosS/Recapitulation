using System;
using System.Globalization;

namespace Recapitulation {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Esse programa foi criado para facilitar a recaptulação de conteúdos básicos da linguagem C");
            Console.WriteLine("***");
            Console.WriteLine("Digite o número para recaptular o conteúdo desejado ou 0 para encerrar o programa: ");

            int acao = Console.ReadLine();

            while(acao != 0) {
                if(acao == 1) {
                    Console.WriteLine("Ação 1");
                } else {
                    Console.WriteLine("Ação diferente");
                }
            }

        }
    }
}