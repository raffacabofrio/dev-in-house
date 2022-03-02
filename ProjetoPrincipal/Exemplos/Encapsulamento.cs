using static System.Console;


public class Encapsulamento
{
    public void Exemplos()
    {
        var r = new Retangulo();
        WriteLine("Informe o comprimento: ");
        r.Comprimento = Convert.ToDouble(Console.ReadLine());
        WriteLine("Informe a largura : ");
        r.Largura = Convert.ToDouble(Console.ReadLine());
        WriteLine($"Area do Retangulo: {r.GetArea()}");
    }

}

class Retangulo
{
    //variáveis membros
    private double comprimento;
    private double largura;

    public double Comprimento
    {
        get { return comprimento; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O valor do comprimento não pode ser menor que zero");
            }
            else
            {
                comprimento = value;
            }
        }
    }

    public double Largura
    {
        get { return largura; }
        set
        {
            if (value < 0)
            {
                throw new Exception("O valor da largura não pode ser menor que zero");
            }
            else
            {
                largura = value;
            }
        }
    }

    public double GetArea()
    {
        return Comprimento * Largura;
    }
}

