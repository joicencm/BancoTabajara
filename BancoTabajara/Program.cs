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
            conta1.movimentacoes = new Movimentacao[10];
            

            conta1.Sacar(300);
            conta1.Depositar(500);
            conta1.ConsultarSaldo();

            ContaCorrente conta2 = new ContaCorrente();
            conta2.saldo = 1500;
            conta2.numero = 10311;
            conta2.limite = 0;
            conta2.movimentacoes = new Movimentacao[10];

            conta1.transferirPara(conta2, 501);
            conta2.ConsultarSaldo();

            conta1.ExibirExtrato();

            conta2.ExibirExtrato();

            Console.ReadLine();
        }
    }
}
