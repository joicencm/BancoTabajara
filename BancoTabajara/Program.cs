namespace BancoTabajara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.saldo = 3500;
            conta1.numero = 10310;
            conta1.limite = 0;
            

            conta1.Sacar(300);

            Console.ReadLine();
        }
    }
}
