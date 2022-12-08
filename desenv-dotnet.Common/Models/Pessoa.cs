using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desenv_dotnet.Common.Models
{
    /// <summary>
    /// Representa uma pessoa
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Apresenta a pessoa, dizendo nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}