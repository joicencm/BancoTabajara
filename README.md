# 🏦 BancoTabajara

Um sistema bancário simples em C#, desenvolvido para simular operações básicas de uma conta corrente como **saque**, **depósito**, **transferência** e **emissão de extrato**.

## ⚙️ Funcionalidades

- Criar contas correntes com número, saldo e limite.
- Realizar **saques** e **depósitos**.
- **Transferir** valores entre contas.
- **Registrar e exibir movimentações** em forma de extrato.

## 🧱  Estrutura

O projeto contém duas classes principais:

- `Movimentacao`: Representa uma transação, contendo o valor e o tipo (`Débito` ou `Crédito`).
- `ContaCorrente`: Contém os dados da conta e os métodos para movimentações.

```csharp
// Exemplo de movimentação
movimentacoes[m].Tipo: R$ movimentacoes[m].Valor
```

## 🚀 Como Executar
git clone https://github.com/joicencm/BancoTabajara.git

## 🧪 Exemplo de uso
```cshar
ContaCorrente conta1 = new ContaCorrente();
conta1.saldo = 3500;
conta1.Sacar(300);
conta1.Depositar(500);
conta1.ConsultarSaldo();
conta1.ExibirExtrato();
```

## 💻 Saída esperada no console:
```cshar
Saldo atual: R$ 3700.00
Extrato da conta 10310
Débito: R$ 300.00
```

## 🛠️  Tecnologias
[![My Skills](https://skillicons.dev/icons?i=visualstudio,cs,dotnet,git,github)](https://skillicons.dev)