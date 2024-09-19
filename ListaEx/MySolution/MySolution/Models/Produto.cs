using System;
using Microsoft.AspNetCore.SignalR;

namespace MySolution.Models;

public class Produto
{

    
    //C# - Construtor 
    public Produto()
    {
        Id = Guid.NewGuid().ToString();//Guid = identificador unico global
        CriadoEm = DateTime.Now;
    }
    // C# - Atributos, get e set
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    public DateTime CriadoEm { get; set; }

    // Java - Atributos, get e set
    // private double preco;

    // public double getPreco()
    // {
    //     return this.preco;
    // }

    // public void setPreco(double preco)
    // {
    //     this.preco = preco * 2;
    // }
}
