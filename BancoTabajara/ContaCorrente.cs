namespace BancoTabajara
{
    public class ContaCorrente
    {
        public int numero;
        public double saldo;
        public double limite;

        public void Sacar(double valor)
        {
            if (valor > saldo + limite)
                Console.WriteLine("Saldo insulficiente");

            saldo -= valor;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
    }
}
