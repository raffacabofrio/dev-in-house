// Assembly separado

namespace Assembly2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("RODANDO O PROGRAMA A PARTIR DE OUTRO ASSEMBLY...");

            var mimosa = new Vaca();
            var estranho = new Ornitorrinco();

            Console.WriteLine("Peso da vaca:");
            mimosa.MostraPeso();

            Console.WriteLine("Peso do Ornitorrinco:");
            estranho.MostraPeso();

            // ERRO! Não pode acessar o internal do outro assembly.
            Console.WriteLine("Idade da vaca:" + mimosa.Idade);

        }
    }
}
