using System;

namespace Section_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string day;
            byte loop = 0;
            do
            {
                Console.WriteLine("Digite o número do dia da semana, domingo é zero: ");
                byte x = byte.Parse(Console.ReadLine());
                switch (x)
                {
                    case 0: day = "Domingo"; break;
                    case 1: day = "Segunda"; break;
                    case 2: day = "Terça"; break;
                    case 3: day = "Quarta"; break;
                    case 4: day = "Quinta"; break;
                    case 5: day = "Sexta"; break;
                    case 6: day = "Sabado"; break;
                    default: day = "Valor inválido!"; break;
                }
                Console.WriteLine("O dia foi: {0}", day);
                Console.WriteLine("Digite 5 para repetir, ou outro para sair!");               
                loop = byte.Parse(Console.ReadLine());
                string rep;
                rep = (loop == 5) ? "Vai repetir!" : "NÃO REPETIRÁ ! Tchau!";
                Console.WriteLine(rep);
            } while (loop == 5);
            Console.WriteLine("Mensagem 1 testes Git");
            Console.WriteLine("Mensagem 2 testes Git");
        }
    }
}
