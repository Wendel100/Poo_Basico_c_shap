namespace PooC_sharp
{
    public abstract class Veiculos : IManutencao
    {
        string Placa;
        int Ano;
        public Veiculos(string placa, int ano)
        {
            Placa = placa;
            Ano = ano;
        }
        public abstract double calcularSeguro();

        public void ExibirDetalhes(){
            System.Console.WriteLine($"A placa deste veiculo e :{Placa} e o ano {Ano}");
        }

        public string realizarManutencao()
        {
            return "Manutencao realizada com sucesso";
        }

    }
}