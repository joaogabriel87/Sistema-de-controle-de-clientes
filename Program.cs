using System;
using Desenvolvimento_de_sistema_de_controle_de_clientes;

internal class Program
{
    static void Main(string[] args)
    {
        float valPago;
        Console.WriteLine("Informe seu nome");
        string nomeclatura = Console.ReadLine();
        Console.WriteLine("Informe seu endereço");
        string residencia = Console.ReadLine();
        Console.WriteLine("Pessoa Fisica(f) ou Pessoa Juridica(j)?");
        string tipo = Console.ReadLine();
        if (tipo == "f")
        {
            PessoFisica pf = new PessoFisica();
            pf.nome = nomeclatura;
            pf.endereco = residencia;
            Console.WriteLine("Infomrar seu CPF");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("informe seu RG");
            pf.rg = Console.ReadLine();
            Console.WriteLine("Informe o valor da compra: ");
            valPago = float.Parse(Console.ReadLine());
            pf.PagarImposto(valPago);
            Console.WriteLine("--------Pessoa Física--------");

            Console.WriteLine("Nome.....: " + pf.nome);
            Console.WriteLine("Endereço.....: " + pf.endereco);
            Console.WriteLine("CPF.....: " + pf.cpf);
            Console.WriteLine("RG.....: " + pf.rg);
            Console.WriteLine("Valor de compra.....: " + pf.valor.ToString("C"));
            Console.WriteLine("Imposto.....: " + pf.valor_imposto.ToString("C"));
            Console.WriteLine("Total a pagar.....: " + pf.total.ToString("C"));
        }

        else if (tipo == "j")
        {
            PessoaJuridica pj = new PessoaJuridica();
            pj.nome = nomeclatura;
            pj.endereco = residencia;
            Console.WriteLine("Infomrar seu CNPJ");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("informe seu IE");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informe o valor da compra: ");
            valPago = float.Parse(Console.ReadLine());
            pj.PagarImposto(valPago);
            Console.WriteLine("--------Pessoa Juridica--------");

            Console.WriteLine("Nome.....: " + pj.nome);
            Console.WriteLine("Endereço.....: " + pj.endereco);
            Console.WriteLine("CPF.....: " + pj.cnpj);
            Console.WriteLine("RG.....: " + pj.ie);
            Console.WriteLine("Valor de compra.....: " + pj.valor.ToString("C"));
            Console.WriteLine("Imposto.....: " + pj.valor_imposto.ToString("C"));
            Console.WriteLine("Total a pagar.....: " + pj.total.ToString("C"));
        }

        else
        {
            Console.WriteLine("Digite uma das opção a cima");
            
        }
        }

    }
