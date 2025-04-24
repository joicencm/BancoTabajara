
namespace BancoTabajara
{
    public class Movimentacao
    {
        public decimal valor;
        public string tipo;

        public string ExbirMovimentacao()
        {
            return $"{tipo} - {valor.ToString("C2")}";
        }
    }
}
