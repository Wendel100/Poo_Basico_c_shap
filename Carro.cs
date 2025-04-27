namespace PooC_sharp
{
    public class Carro : Veiculos
    {
        int numeroPortas = 4;
        double preco = 20.60;
        double valor;
        public Carro(string placa, int ano) : base(placa, ano){}
        public override double calcularSeguro()
        {
            valor = numeroPortas * preco;
            return valor;
        }

    }
}