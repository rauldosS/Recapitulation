using System;
using System.Globalization;

namespace Recapitulation {
    class Program {
        static void Main(string[] args) {
            /* Variáveis */
            bool complete = false;
            char gender = 'F';
            char letter = '\u0031';

            string nome = "Raul";
            int idade = 22;

            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483647L;
            float n5 = 4.5f;

            object obj1 = "Alex Brown";
            object obj2 = 3.4f;

            // Valor minimo e máximo de uma variável
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            /* Nomenclatura das variáveis */

            /*
                Imprimir na saída padrão console

                • Comandos

                    → Console.Write: Não quebra linha
                    → c + w + tab + tab (teclado): Atalho
            */

            double saldo = 10.412312;

            Console.WriteLine("Hello World!");
            Console.WriteLine(saldo.ToString("F2")); // Limita o número de casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // Alterar o seperador decimal

            /* Concatenação, placeholders e interpolação */

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            /* Operadores de atribuição */

            int a = 10;

            a += 2;
            a = 10;
            a += 2;
            a -= 2;
            a *= 2;
            a /= 2;
            a %= 3;

            /* Operadores aritméticos / atribuição */

            a++; // Retorna incremento de 1
            a--; // Retorna decremento de 1

            int b = ++a; // Primeira incrementa e depois atribui

            /* Conversão implícita e casting
               
                Casting: conversão explícita entre tipos COMPATÍVEIS

                → https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            */

            // Conversão implicita
            double a1;
            float b1;
            a1 = 5.1;
            b1 = (float)a1;
            Console.WriteLine(b1);

            // Casting

            double a2;
            int b2;
            a2 = 5.1;
            b2 = (int)a2;
            Console.WriteLine(b2);


            /* Entrada de dados (parte 1)
                
                • Lê da entrada padrão até a quebra de linha.
                • Retorna os dados lidos na forma de string.
            */

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');

            string a3 = v[0];
            string b3 = v[1];
            string c3 = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a3);
            Console.WriteLine(b3);
            Console.WriteLine(c3);

            /* Entrada de dados (parte 2)
             
            */

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            /**/
            /**/
            /**/
            /**/
            /**/
            /**/
            /**/
            /**/
            /**/
        }
    }
}