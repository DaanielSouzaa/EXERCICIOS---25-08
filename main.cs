using System;
using System.Collections.Generic;

public class Example
{ 
  string resposta = "s";
  string item;

    public static void GeraCardapio() {
      IDictionary<string, string> ItemNome =
            new Dictionary<string, string>();

        ItemNome.Add("100", "Cachorro quente");
        ItemNome.Add("101", "Bauru Simples");
        ItemNome.Add("102", "Bauru com ovo");
        ItemNome.Add("103", "Hamburguer");
        ItemNome.Add("104", "Cheeseburguer");
        ItemNome.Add("105", "Refrigerante");
    
      IDictionary<string, double> ItemValor =
              new Dictionary<string, double>();

          ItemValor.Add("100",1.70);
          ItemValor.Add("101",2.30);
          ItemValor.Add("102",2.60);
          ItemValor.Add("103",2.40);
          ItemValor.Add("104",2.50);
          ItemValor.Add("105",1.00);
    }

    public static void ExibeCardapio(ItemNome,ItemValor) {
        foreach(KeyValuePair<string, string> kvp in ItemNome)
        {
            Console.WriteLine("{0} {1} {2}",
                kvp.Key, kvp.Value,ItemValor[kvp.key]);
        }
    }

    public static void Main()
    {
      GeraCardapio();
      ExibeCardapio(ItemNome);
    }
}