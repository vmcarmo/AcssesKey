using System;
using System.Threading;

namespace AcssesKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Digite a chave de acesso para identificar o modelo da NFe");
            Console.WriteLine("Digite 0 para sair.");
            Console.WriteLine("---------------------------------------------------------");

            string acssesKey = Console.ReadLine();

            //Para fechar o app.
            if (acssesKey == "0")
                System.Environment.Exit(0);

            //Validando a chave de acesso.
            if (acssesKey.Length != 44)
            {
                Console.WriteLine("Chave de acesso incorreta.");
                Thread.Sleep(2500);
                Menu();
            }

            int model = int.Parse(acssesKey.Substring(20, 2));
            string answer = "Modelo 57 CTE - Conhecimento de Transporte";

            if (model == 55)
                answer = "Modelo 55 NFE - Nota Fiscal de Venda";

            if (model != 55 && model != 57)
                answer = "Chave de acesso incorreta.";

            Console.WriteLine(answer);
            Thread.Sleep(5000);

            Menu();
        }
    }
}
