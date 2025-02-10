using System;

// Classe Atleta
class Atleta
{
    public string Nome { get; set; }
    public string Sport { get; set; }
    public int Età { get; set; }

    public void Allenarsi()
    {
        Console.WriteLine($"{Nome} si sta allenando per {Sport}.");
    }
}

// Classe Dipendente
class Dipendente
{
    public string Nome { get; set; }
    public string Ruolo { get; set; }
    public double Stipendio { get; set; }

    public void Lavora()
    {
        Console.WriteLine($"{Nome}, che lavora come {Ruolo}, sta lavorando.");
    }
}

// Classe Animale
class Animale
{
    public string Nome { get; set; }
    public string Specie { get; set; }
    public int Età { get; set; }

    public void Verso()
    {
        Console.WriteLine($"{Nome}, un {Specie} di {Età} anni, miagola.");
    }
}

// Classe Veicolo
class Veicolo
{
    public string Marca { get; set; }
    public string Modello { get; set; }
    public int Anno { get; set; }

    public void AccendiMotore()
    {
        Console.WriteLine($"Il veicolo {Marca} {Modello} del {Anno} è stato acceso.");
    }
}

// Programma principale
class Program
{
    static void Main()
    {
        // Creazione istanze delle classi
        Atleta atleta = new Atleta { Nome = "Mario", Sport = "Calcio", Età = 25 };
        Dipendente dipendente = new Dipendente { Nome = "Luca", Ruolo = "Programmatore", Stipendio = 2500.50 };
        Animale animale = new Animale { Nome = "Micio", Specie = "Gatto", Età = 2 };
        Veicolo veicolo = new Veicolo { Marca = "Lamborghini", Modello = "Urus Performante", Anno = 2024 };

        // Stampa a schermo
        atleta.Allenarsi();
        dipendente.Lavora();
        animale.Verso();
        veicolo.AccendiMotore();
    }
}
