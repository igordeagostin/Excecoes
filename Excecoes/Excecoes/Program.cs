using System;
using System.IO;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? valor = null;

            //Classe validação

            if (valor == 0)
            {
                throw new ArgumentException("Por favor, digite um valor difente de zero");
            }
            else if (valor == null)
            {
                throw new ArgumentNullException("Por favor, digite um valor diferente de nulo.");
            }

            string arquivo = null;

            if (arquivo == null)
            {
                throw new FileNotFoundException("Arquivo não encontrado.");
            }
            else if (arquivo != null && arquivo.Length == 0)
            {
                throw new FileLoadException("Falha ao carregar o arquivo.");
            }

            try
            {
                int inteira = Convert.ToInt32("nome");
            }
            catch (FormatException ex)
            {
                throw ex;
            }

            //Excecoes personalizadas

            int valor2 = 8;

            if (valor2 == 8)
            {
                throw new ExcecaoPersonalizadaException("Essa é uma excecao personalizada.");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
