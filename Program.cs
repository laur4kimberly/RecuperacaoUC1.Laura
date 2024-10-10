using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString()
    {
        return $"{Nome} - R$ {Preco:F2}";
    }
}

class Pedido
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in produtos)
        {
            total += produto.Preco;
        }
        return total;
    }

    public void ExibirPedido()
    {
        Console.WriteLine("Produtos no pedido:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }
}

class Program
{
    static void Main()
    {
        List<Produto> menu = new List<Produto>
        {
            new Produto("Hambúrguer", 15.00m),
            new Produto("Cheeseburguer", 17.00m),
            new Produto("Batata Frita", 10.00m),
            new Produto("Refrigerante", 5.00m),
            new Produto("Suco", 7.00m)
        };
    }
}


