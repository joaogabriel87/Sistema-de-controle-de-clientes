using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desenvolvimento_de_sistema_de_controle_de_clientes
{
    public class Clientes
    {
        public String nome{get; set;}

        public String endereco{get; set;}

        public float valor{get; protected set;}
        public float valor_imposto{get; protected set;}
        public float total{get; protected set;}



        

        public virtual void  PagarImposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10/100;
            this.total = this.valor + this.valor_imposto;

        }
    }
}