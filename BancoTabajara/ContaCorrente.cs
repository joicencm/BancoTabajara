namespace BancoTabajara
{
    public class ContaCorrente
    {
        public int numero;
        public double saldo;
        public double limite;

        public double Sacar(double valor)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado com sucesso. Saldo atual de R$ {saldo}");
            return valor;
        }
    }
}
