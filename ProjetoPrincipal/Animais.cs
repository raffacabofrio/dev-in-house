public class Animal
{
    private int Altura;
    protected int Peso;
    internal int Idade;

    public void MostraPeso()
    {
        Console.WriteLine(Peso);
    }

}

public class Vaca : Animal
{
    public Vaca()
    {
        Peso = 200;
        Idade = 10;

        // Não pode mexer em campos private da classe pai
        // ERRO!!!
        // Altura = 100;
    }
}

public class Ornitorrinco : Animal
{
    public Ornitorrinco()
    {
        Peso = 10;
        Idade = 5;
    }

    public new void MostraPeso()
    {
        Console.WriteLine("dkhaskdh sd kjshdahsdsad kjshda");
        Console.WriteLine(Peso);
    }
}