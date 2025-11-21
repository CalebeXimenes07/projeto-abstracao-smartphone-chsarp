using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProejtoAbstracaoCelular.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeDoApp)
        {
            Console.WriteLine($"Instalando o {nomeDoApp}...");
        }
    }
}