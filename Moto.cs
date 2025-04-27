namespace PooC_sharp
{
    public class Moto : Veiculos
    {
        int cilindrada = 2;
        double preco = 30.60;
        double valor;

        public Moto(string placa, int ano) : base(placa, ano){}
        public override double calcularSeguro()
        {
            valor = cilindrada * preco;
            return valor;  
        }

    }
}