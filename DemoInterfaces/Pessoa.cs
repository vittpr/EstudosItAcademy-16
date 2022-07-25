public class Pessoa : IEquatable<Pessoa>
{

    private string nome;
    private int idade;

    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string Nome
    {
        get { return nome; }
    }
    public int Idadelse
    {
        get { return idade; }
    }

    public bool Equals(Pessoa? outra)
    {
        if (outra == null)
        return false;
        return (nome == outra.nome && idade == outra.idade);
    }

    public override bool Equals(object? obj)
    {
       Pessoa? outra = obj as Pessoa;
       return Equals(outra);
    }

    public override int GetHashCode()
    {
        return nome.GetHashCode() + idade.GetHashCode();
    }
}