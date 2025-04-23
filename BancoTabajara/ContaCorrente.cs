
namespace BancoTabajara
{
    public class Movimentacao
    {
        public double Valor;
        public string Tipo;

        public Movimentacao(double valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }

    public class ContaCorrente
    {
        public int numero;
        public double saldo;
        public double limite;
        public Movimentacao[] movimentacoes;
        public int contadorMovimentacoes = 0;

        public void Sacar(double valor)
        {
            if (valor > saldo + limite)
                Console.WriteLine("Saldo insulficiente");

            saldo -= valor;
            RegistrarMovimentacao(new Movimentacao(valor, "Débito"));
        }

        public void RegistrarMovimentacao(Movimentacao movimentacao)
        {
            movimentacoes[contadorMovimentacoes++] = movimentacao;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            RegistrarMovimentacao(new Movimentacao(valor, "Crédito"));
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }

        public void transferirPara(ContaCorrente destino, int valor)
        {
            if (valor > saldo + limite)
                Console.WriteLine("Saldo insulficiente, ou ultrapassou o limite");

            this.Sacar(valor);
            destino.Depositar(valor);
            Console.WriteLine($"Transferência de R$ {valor:F2} realizada para a conta {destino.numero}.");
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"Extrato da conta {numero}");
            for (int m = 0; m < contadorMovimentacoes; m++)
                Console.WriteLine($"{movimentacoes[m].Tipo}: R$ {movimentacoes[m].Valor:F2}");
        }
    }
}
