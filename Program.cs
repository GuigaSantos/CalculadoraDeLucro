using System;

public class Example
{
    public static void Main()
    {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Title = "Calculador de Lucro";
        Console.Clear();

        try
        {
            Console.Write("(Responda somente em numeros, sem simbolos ou letras)\nDigite seu valor de vendas: ");
            double valVendas = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("(Responda somente em numeros, sem simbolos ou letras)\nDigite seu valor de custo: ");
            double valCusto = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            double lucroLiquido = valVendas - valCusto;
            double porcentagem = (lucroLiquido/valVendas);


            Console.WriteLine("Val.Venda....: {0, 5:c}", valVendas);
            Console.WriteLine("Val.Custo....: {0, 5:c}", valCusto);
            Console.WriteLine("Lucro........: {0, 5:c}", lucroLiquido);
            Console.WriteLine("porcentagem..: {0, 5:p}", porcentagem);
            Console.WriteLine("\nPressione qualquer tecla para fechar");
            Console.ReadKey();
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Resposta invalida\nPressione qualquer tecla para fechar");
            Console.Title = "Valor inexperado";
            Console.ReadKey();
        }
    }
}