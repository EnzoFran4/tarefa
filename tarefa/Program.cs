using tarefa;
using tarefa.Classe;


while(true)
{
    Console.WriteLine("1 - Conta empresarial");
    Console.WriteLine("2 - Conta estudantil");

     int opçao = Convert.ToInt32(Console.ReadLine());
     
    if(opçao == 1 )
    {
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Empréstimo");
        Console.WriteLine("2 - Sacar");
        int op = Convert.ToInt32(Console.ReadLine());   

        if (op == 1 )
        {
           
            
          
            Console.WriteLine("Qual a sua agência?");
            string agencia = Console.ReadLine();



            Console.WriteLine("Qual o nome do titular?");
            string titular = Console.ReadLine();
            

            ContaEmpresarial c = new ContaEmpresarial(100, 2000, 005, agencia, titular, 10000);
            Console.WriteLine("Quanto você deseja receber de empréstimo?");
            double empréstimo = Convert.ToDouble(Console.ReadLine());
            c.FazerEmpréstimo(empréstimo);
        }
        if (op == 2 )
        {
            
            Console.WriteLine("Qual a sua agência?");
            string agencia = Console.ReadLine();
          
          
            
            Console.WriteLine("Qual o nome do titular?");
            string titular = Console.ReadLine();
            Console.WriteLine("Qual seu saldo?");
            double saldo = Convert.ToDouble(Console.ReadLine());

            ContaEmpresarial c = new ContaEmpresarial(100, 2000, 005, agencia, titular, saldo);
            Console.WriteLine("Quanto você deseja sacar?");
            double saque = Convert.ToDouble(Console.ReadLine());
            c.Sacar(saque);
        }
        else
        {
            Console.WriteLine("Inválido!");
        }

    }
    if(opçao == 2 )
    {
        Console.WriteLine("O que deseja fazer?");
        
        Console.WriteLine("1 - Sacar");
        int op = Convert.ToInt32(Console.ReadLine());

        if (op == 1)
        {
             
            Console.WriteLine("Qual seu cpf?");
            string cpf = Console.ReadLine();
            Console.WriteLine("Qual o nome da sua instituição?");
            string instituiçao = Console.ReadLine();
            
            Console.WriteLine("Qual a sua agência?");
            string agencia = Console.ReadLine();
            Console.WriteLine("Qual o nome do titular?");
            string titular = Console.ReadLine();
      

            Estudante c = new Estudante(1000,cpf,instituiçao,005,agencia,titular, 10000);
            Console.WriteLine("Quanto você deseja sacar?");
            double saque = Convert.ToDouble(Console.ReadLine());
            c.Sacar(saque);
        }
       
        else
        {
            Console.WriteLine("Inválido!");
        }
    }
    else
    {
        Console.WriteLine("Inválido!");
    }

     
}




