public class ContaCorrente
 {
    private decimal saldo;

    private Correntista correntista;

    public decimal Saldo 
    {
        get{return saldo;}
    }
    
    // public decimal Saldo => saldo;
public DateTime DataCriacao { get;}

public Correntista Correntista => Correntista;
    public void Depositar(decimal valor)
    {
        saldo = saldo + valor;
    }

    public void Sacar(decimal valor)
    {
        saldo = saldo - valor;
    }

    public ContaCorrente(decimal valor, Correntista umCorrentista)
    {
        saldo = valor;
        DataCriacao = DateTime.Now;
        correntista = umCorrentista;
    }

    public ContaCorrente(string nomeCorrentista, string cpfCorrentista)
    : this(0, new Correntista {Nome = nomeCorrentista, Cpf=cpfCorrentista})
    {
    }
}