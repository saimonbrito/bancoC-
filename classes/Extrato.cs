using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.classes
{
    public class Extrato
    {
        public Extrato(DateTime data, string descrricao, double valor)
        {
            this.Data = data;
            this.Descricao = descrricao;
            this.Valor = valor;

        }

        public DateTime Data { get; set; }  
        public string Descricao { get; set; }
        public double Valor { get; set; }   
    }
}
