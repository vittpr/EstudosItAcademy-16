﻿ContaCorrente conta1 = new ContaCorrente(0);
ContaCorrente conta2 = new ContaCorrente(1);
conta1.Depositar(100);
conta1.Sacar(50);
Console.WriteLine(conta1.Saldo);
Console.WriteLine(conta1.DataCriacao.ToShortDateString());

Correntista c1 = new Correntista{Nome="John Doe", Cpf="12345678954"};
Console.WriteLine(c1.Nome);
Console.WriteLine(c1.Cpf);