using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TelefoneSemFio
{
    public void Exemplos()
    {
        var crianca1 = new Crianca();
        var crianca2 = new Crianca();
        var crianca3 = new Crianca();
        var crianca4 = new Crianca();
        var crianca5 = new Crianca();
        var crianca6 = new Crianca();
        var crianca7 = new Crianca();
        var crianca8 = new Crianca();
        var crianca9 = new Crianca();
        var crianca10 = new Crianca(); // sem amigo

        crianca1.Amigo = crianca2;
        crianca2.Amigo = crianca3;
        crianca3.Amigo = crianca4;
        crianca4.Amigo = crianca5;
        crianca5.Amigo = crianca6;
        crianca6.Amigo = crianca7;
        crianca7.Amigo = crianca8;
        crianca8.Amigo = crianca9;
        crianca9.Amigo = crianca10;


        crianca1.OuvirAFrase("Quem espera sempre alcança.");

        Console.WriteLine(crianca10.Frase);
    }
}


class Crianca
{
    public string Frase { get; set; } = "";
    public Crianca? Amigo { get; set; } = null;

    public void OuvirAFrase(string frase)
    {
        var fraseEmbaralhada = EmbaralhaFrase(frase);
        Frase = fraseEmbaralhada;

        if (Amigo != null)
            Amigo.OuvirAFrase(Frase);
    }

    private string EmbaralhaFrase(string frase)
    {
        Random number = new Random();
        int resultadoDado = number.Next(2);

        // 50% de chance de embaralhar a frase
        if (resultadoDado == 1)
        {
            var tamanhoString = frase.Length;
            var posicaoAletoriaNaString = number.Next(0, tamanhoString - 1);

            var letraAleatoria = GetLetter();

            frase = ReplaceAtIndex(posicaoAletoriaNaString, letraAleatoria, frase);


        }

        return frase;
    }

    public char GetLetter()
    {
        string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
        Random rand = new Random();
        int num = rand.Next(0, chars.Length);
        return chars[num];
    }

    public string ReplaceAtIndex(int i, char value, string word)
    {
        char[] letters = word.ToCharArray();
        letters[i] = value;
        return string.Join("", letters);
    }
}

