public class Modificadores
{
    public void Exemplos()
    {
        Exemplo01();
    }

    public void Exemplo01()
    {
        var mimosa = new Vaca();
        var estranho = new Ornitorrinco();

        Console.WriteLine("Peso da vaca:");
        mimosa.MostraPeso();

        Console.WriteLine("Peso do Ornitorrinco:");
        estranho.MostraPeso();


        // Aqui funciona porque está no mesmo Assembly
        // Repare que no outro "ExemploAssemblySeparado" NÃO FUNCIONA!
        Console.WriteLine("Idade da vaca:" + mimosa.Idade);
    }
}

public class Animal
{
    private int Altura;
    protected int Peso;
    internal int Idade; // apenas o próprio 

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