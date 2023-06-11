using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public class PessoaJuridica : Clientes
    {
        public string cnpj{get; set;}

        public string ie{get; set;}

        public override void PagarImposto(float v)
        {
           this.valor = v;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }

       
    }
}