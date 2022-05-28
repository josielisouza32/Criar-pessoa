

using System;

namespace Classe
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;   //variavel dentro da classe é atributo.

        public void ExibirNomeCompleto()
        {
            Console.WriteLine($"{nome} {sobrenome}");

        }

        public void ExibirFaixaidade ()
        {
            if (idade >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");
        }
    }
}
   
