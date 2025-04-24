
namespace BancoTabajara
{

    public class ContaCorrente
    {
        public int numero;
        public decimal saldo;
        public decimal limite;
        public Movimentacao[] movimentacoes;
        public int contadorMovimentacoes = 0;

        public void Sacar(decimal quantia)
        {

            if (quantia <= saldo + limite)
            {
            saldo -= quantia;
                Movimentacao novaMovimentacao = new Movimentacao();
                novaMovimentacao.valor = quantia;
                novaMovimentacao.tipo = "Débito";

                movimentacoes[contadorMovimentacoes] = novaMovimentacao;
                contadorMovimentacoes++;
            }
            else
                Console.WriteLine($"Transação no valor de {quantia.ToString("C2")} não foi efetuada. Saldo insulficiente, ou ultrapassou o limite");
        }

        public void Depositar(decimal quantia)
        {
            saldo += quantia;
            Movimentacao novaMovimentacao = new Movimentacao();
            novaMovimentacao.valor = quantia;
            novaMovimentacao.tipo = "Crédito";

            movimentacoes[contadorMovimentacoes] = novaMovimentacao;
            contadorMovimentacoes++;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo.ToString("C2")}");
        }

        public void transferirPara(ContaCorrente destino, int quantia)
        {
            if (quantia <= saldo + limite)
            {
            this.Sacar(quantia);
            destino.Depositar(quantia);
            Console.WriteLine($"Transferência de {quantia.ToString("C2")} realizada para a conta {destino.numero}.");
            }
            else
                Console.WriteLine($"Transação no valor de {quantia.ToString("C2")} não foi  efetuada. Saldo insulficiente, ou ultrapassou o limite");
        }

        public void ExibirExtrato()             
        {
            Console.WriteLine("Extrato da conta " + this.numero);
            Console.WriteLine("Saldo: " + this.saldo.ToString("C2"));

            Console.WriteLine();

            for (int m = 0; m < movimentacoes.Length; m++)
            {
                Movimentacao movimentacaoAtual = movimentacoes[m];
                if (movimentacaoAtual != null)
                    Console.WriteLine(movimentacaoAtual.ExbirMovimentacao());

            }
        }
    }
}
