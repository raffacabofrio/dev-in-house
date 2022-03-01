
//var exemploCtor = new ExemplosConstructorDestructor();
//exemploCtor.Exemplos();

ExemploModificadores();


void ExemploModificadores()
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













