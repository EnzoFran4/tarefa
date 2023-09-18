using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa.Classe;

namespace tarefa
{
    internal class Estudante : Conta
    {
        public double limite_cheque_Especial { get; set; }
        public string cpf { get; set; }
        public string nomeinstituiçao { get; set; }

        public Estudante(double limite_cheque_Especial, string cpf, string nomeinstituiçao, int numero_conta, string agencia, string titular, double saldo)
           :base ( numero_conta, agencia, titular, saldo)


        {
            this.limite_cheque_Especial = limite_cheque_Especial;
            this.cpf = cpf;
            this.nomeinstituiçao = nomeinstituiçao;


        }
        public override void Sacar (double valor)
        {
            if (valor <= limite_cheque_Especial + saldo)
            {
                
                Console.WriteLine("Saque de " +valor.ToString("C2") + " realizado com sucesso!");
                saldo = saldo - valor;
                Console.WriteLine("Seu saldo atual é de" + saldo.ToString("C2"));
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }


    }
}
