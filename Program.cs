using System;
using System.Linq;

public class DubstepAnalyzer
{
    /// <summary>
    /// Reconstruye la canción original a partir de un remix de dubstep, utilizando LINQ e iteración.
    /// </summary>
    /// <param name="dubstepRemix">La cadena del remix dubstep.</param>
    /// <returns>La canción original.</returns>
    public string Analyze(string dubstepRemix)
    {
        // Dividir la cadena por "WUB" para obtener un array de palabras.
        // Se utiliza StringSplitOptions.RemoveEmptyEntries para eliminar las cadenas vacías
        // que resultan de "WUB" consecutivos o al inicio/final.
        var words = dubstepRemix.Split(new[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries);

        // LINQ se utiliza para asegurar que las palabras se procesen como una colección.
        // Aquí, Select(word => word) no cambia la colección, pero demuestra el uso de LINQ
        // antes de la operación de unión.
        var originalWords = words.Select(word => word);

        // Se usa String.Join para unir las palabras de la colección,
        // lo que internamente itera sobre cada elemento.
        return string.Join(" ", originalWords);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var analyzer = new DubstepAnalyzer();

        // Casos de prueba para verificar el funcionamiento
        string remix1 = "AWUBBWUBC";
        string remix2 = "WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB";
        string remix3 = "WUBWUBIAMWUBX";

        Console.WriteLine($"Original de '{remix1}': {analyzer.Analyze(remix1)}");
        Console.WriteLine($"Original de '{remix2}': {analyzer.Analyze(remix2)}");
        Console.WriteLine($"Original de '{remix3}': {analyzer.Analyze(remix3)}");
    }
}