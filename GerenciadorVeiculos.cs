using PooC_sharp;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Veiculos> veiculos =  new List<Veiculos>(){};

        veiculos.Add(new Carro("Toyta", 2020));
        veiculos.Add(new Moto("Nisssan", 2025));

        foreach(var item in veiculos){
            System.Console.WriteLine($"Lista de veiculos:");
            item.ExibirDetalhes();
            System.Console.WriteLine($"Valor total da manutencao do veiculos : {item.calcularSeguro()}$");
            System.Console.WriteLine(item.realizarManutencao());
        }
    }
}