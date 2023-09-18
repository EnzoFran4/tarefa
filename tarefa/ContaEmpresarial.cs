using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarefa.Classe;

namespace tarefa
{
    internal class ContaEmpresarial:Conta
    {
        public double anuidade { get; set; }
        public string agencia { get; set; }
        public double totalempréstimo { get; set; } 

        public ContaEmpresarial (double anuidade, double totalempréstimo, int numero_conta, string agencia, string titular, double saldo) 
        :base(numero_conta, agencia,titular, saldo)
        { 
          
            this.anuidade = anuidade;
            this.agencia = agencia;
            this.totalempréstimo = totalempréstimo;
        
        
        
        }
        public virtual void FazerEmpréstimo(double valor)
        {
            if (valor <= totalempréstimo)
            {
                Console.WriteLine("Empréstimo de " + valor.ToString("C2") + " realizado com sucesso");
                saldo = saldo + valor;
                Console.WriteLine("Seu saldo atual é de" + saldo.ToString("C2"));
            }
            if(valor > totalempréstimo)
            {
                Console.WriteLine("O valor do empréstimo está acima do limite");
            }
            else
            {
                Console.WriteLine("Inválido");
            }
        }
        public virtual void Sacar(double valor)
        {
           
            
            
           
            if(valor <= saldo)
            {
                if (valor <= 5000)
                {
                    
                    Console.WriteLine("Empréstimo de " + valor.ToString("C2") + " realizado com sucesso!");
                    saldo = saldo - valor;
                    Console.WriteLine("Seu saldo atual é de" + saldo.ToString("C2"));
                }
                else
                {
                    Console.WriteLine("saldo insuficiente");
                }
            }
            if(valor > 5000)
            {
                
                Console.WriteLine("Saque de" + valor.ToString("C2") + " realizado com sucesso!");
                saldo = saldo - valor - 5;
                Console.WriteLine("Seu saldo atual é de" + saldo.ToString("C2"));
            }
        }
    }
}
