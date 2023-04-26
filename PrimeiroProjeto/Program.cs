// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.2345567;

            Console.WriteLine(" Produtos: \r\n {0}, cujo preço é R${1:F2} \r\n {2}, cujo preço é R${3:F2} \r\n", produto1, preco1, produto2, preco2);

            Console.WriteLine(" Registro: {0} anos de idade, código {1} e gênero: {2} \r\n", idade, codigo, genero);

            Console.WriteLine(" Medida com oito casas decimais: {0:F8} \r\n Arredondando (três casas decimais): {1:F3} \r\n Separador decimal invariant culture: {2}", medida, medida, medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
