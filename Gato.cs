using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gato: Animal
    {

        public void Apresentacao()
        {
        
            Console.WriteLine($" Meu nome é {Nome} sou um {Tipo} e faço esse som: {Som}");
        }

        public Gato(string nome, string tipo, string som) 
        {
            Nome = nome;
            Som= som;
            Tipo = tipo;
        }
    }
}
