#region Herança
using System;

// Classe base Animal
/*class Animal
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
*/
#endregion

#region Encapsulamento
/*
class Carro //Definindo a classe Carro que tem dois membros privados
{
    //membros privados para implementar o encapsulamento.
    private string modelo;
    private int ano;

    // Construtor - os valores passados são atributos
    public Carro(string modelo, int ano)
    {
        this.modelo = modelo;
        this.ano = ano;
        //this - objeto atual
    }

    // Método para obter o modelo do carro
    public string GetModelo()
    {
        return modelo;
    }

    // Método para definir o modelo do carro
    public void SetModelo(string modelo)
    {
        this.modelo = modelo;
    }

    // Método para obter o ano do carro
    public int GetAno()
    {
        return ano;
    }

    // Método para definir o ano do carro
    public void SetAno(int ano)
    {
        this.ano = ano;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro("Toyota", 2020);

        // Usando os métodos para acessar e modificar os membros privados
        Console.WriteLine("Modelo: " + meuCarro.GetModelo());
        Console.WriteLine("Ano: " + meuCarro.GetAno());

        meuCarro.SetModelo("Honda");
        meuCarro.SetAno(2018);

        Console.WriteLine("Novo modelo: " + meuCarro.GetModelo());
        Console.WriteLine("Novo ano: " + meuCarro.GetAno());
    }
}

*/
#endregion

#region Abstração
/*
// Classe abstrata que representa um animal genérico
abstract class Animal
{
    // Método abstrato para fazer o animal emitir um som
    public abstract void EmitirSom();
}

// Subclasse que representa um cachorro
class Cachorro : Animal
{
    // Implementação do método EmitirSom para o cachorro
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

// Subclasse que representa um pássaro
class Passaro : Animal
{
    // Implementação do método EmitirSom para o pássaro
    public override void EmitirSom()
    {
        Console.WriteLine("Piu piu!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando objetos das subclasses
        Animal cachorro = new Cachorro();
        Animal passaro = new Passaro();

        // Chamando o método EmitirSom para cada animal
        cachorro.EmitirSom(); // Saída: Au au!
        passaro.EmitirSom();  // Saída: Piu piu!
    }
}
*/
#endregion

#region Polimorfismo
/*

// Classe base Animal
class Animal
{
    // Método EmitirSom sobrecarregado (overload)
    public void EmitirSom()
    {
        Console.WriteLine("O animal está fazendo algum som.");
    }

    // Método Correr sobrecarregado (overload)
    public void Correr()
    {
        Console.WriteLine("O animal está correndo.");
    }
}

// Subclasse Cachorro que herda de Animal
class Cachorro : Animal
{
    // Sobreposição (override) do método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo.");
    }

    // Sobrecarga (overload) do método Correr
    public void Correr(int velocidade)
    {
        Console.WriteLine($"O cachorro está correndo a {velocidade} km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Cachorro
        Cachorro meuCachorro = new Cachorro();

        // Chamando os métodos EmitirSom e Correr
        meuCachorro.EmitirSom();       // Saída: O cachorro está latindo.
        meuCachorro.Correr();          // Saída: O animal está correndo.
        meuCachorro.Correr(20);        // Saída: O cachorro está correndo a 20 km/h.
    }
}
*/
#endregion

#region Aplicando os 4 Pilares de POO
/*
// Abstração
public abstract class Animal
{
    public abstract void EmitirSom();
}

// Herança
public class Cachorro : Animal
{
    // Encapsulamento
    private string nome;

    public Cachorro(string nome)
    {
        this.nome = nome;
    }

    // Override (Sobreposição)
    public override void EmitirSom()
    {
        Console.WriteLine($"{nome} está latindo!");
    }
}

// Polimorfismo
public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Polimorfismo
        Animal animal1 = new Cachorro("Rex");
        Animal animal2 = new Gato();

        animal1.EmitirSom(); // Saída: Rex está latindo!
        animal2.EmitirSom(); // Saída: O gato está miando!
    }
}
*/
#endregion

#region Classes Abstratas
/*
// Definição da classe abstrata Veículo
abstract class Veiculo
{
    // Propriedades comuns a todos os veículos
    public string Marca { get; set; }
    public int Ano { get; set; }

    // Método abstrato que todas as subclasses devem implementar
    public abstract void Mover();
}

// Definição da classe Carro, que herda de Veículo
class Carro : Veiculo
{
    // Implementação do método Mover para carro
    public override void Mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }
}

// Definição da classe Moto, que herda de Veículo
class Moto : Veiculo
{
    // Implementação do método Mover para moto
    public override void Mover()
    {
        Console.WriteLine("A moto está se movendo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando objetos das subclasses
        Carro meuCarro = new Carro();
        meuCarro.Marca = "Toyota";
        meuCarro.Ano = 2020;
        meuCarro.Mover(); // Chama o método Mover do carro

        Moto minhaMoto = new Moto();
        minhaMoto.Marca = "Honda";
        minhaMoto.Ano = 2019;
        minhaMoto.Mover(); // Chama o método Mover da moto
    }
}
*/
#endregion

#region Interface
/*
// Definição da interface IDocumento
interface IDocumento
{
    void Abrir();
    void Salvar();
}

// Implementação da classe DocumentoDeTexto que implementa a interface IDocumento
class DocumentoDeTexto : IDocumento
{
    public void Abrir()
    {
        Console.WriteLine("Abrindo documento de texto...");
    }

    public void Salvar()
    {
        Console.WriteLine("Salvando documento de texto...");
    }
}

// Implementação da classe Planilha que implementa a interface IDocumento
class Planilha : IDocumento
{
    public void Abrir()
    {
        Console.WriteLine("Abrindo planilha...");
    }

    public void Salvar()
    {
        Console.WriteLine("Salvando planilha...");
    }
}

// Implementação da classe Apresentacao que implementa a interface IDocumento
class Apresentacao : IDocumento
{
    public void Abrir()
    {
        Console.WriteLine("Abrindo apresentação...");
    }

    public void Salvar()
    {
        Console.WriteLine("Salvando apresentação...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de documentos
        List<IDocumento> documentos = new List<IDocumento>
        {
            new DocumentoDeTexto(),
            new Planilha(),
            new Apresentacao()
        };

        // Abrindo e salvando cada documento na lista
        foreach (var documento in documentos)
        {
            documento.Abrir();
            documento.Salvar();
            Console.WriteLine();
        }
    }
}
*/
#endregion