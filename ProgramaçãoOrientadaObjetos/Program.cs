#region Herança
using System;

// Classe base Animal
class Animal
{
    protected string nome;

    public Animal(string nome)
    {
        this.nome = nome;
    }

    public virtual void FazerSom()
    {
        Console.WriteLine("Animal faz algum som!");
    }
}

// Classe derivada Cachorro
class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome)
    {
    }

    public override void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Classe derivada Gato
class Gato : Animal
{
    public Gato(string nome) : base(nome)
    {
    }

    public override void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando objetos
        Animal rex = new Cachorro("Rex");
        Animal garfield = new Gato("Garfield");

        // Chamando métodos
        rex.FazerSom();
        garfield.FazerSom();
    }
}

#endregion
