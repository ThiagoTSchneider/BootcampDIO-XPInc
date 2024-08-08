using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampDIO_XPInc.Models
{

    //Class convention <-- Class name follows the code written in the .cs
    public class PessoaFisica
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string representanteLegal { get; set; } = string.Empty;

        public void apresentar()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade}");
        }
    }
}