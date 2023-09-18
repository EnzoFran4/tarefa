using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa.Classe
{
    internal class Conta
    {
       public int numero_conta {get; set;}
       public string agencia { get; set;}   
       public string titular { get; set;}   
       public double saldo { get; set;}

        public Conta(int numero_conta, string agencia, string titular, double saldo)
        {
            this.numero_conta = numero_conta;
            this.agencia = agencia;
            this.titular = titular;
            this.saldo = saldo;
        }

        public virtual void Sacar(double valor)
        {
          if(valor <= saldo)
            {
              
                Console.WriteLine(valor.ToString());
            }
          else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public virtual void Depositar(double valor)
        {
            if(valor <= saldo)
            {


                Console.WriteLine("Depósito de " + valor.ToString("C2") + "realizado com sucesso!");

            }
           
        }
    }
}
