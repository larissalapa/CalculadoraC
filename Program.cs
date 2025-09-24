using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de operações a serem realizadas.
        // Cada operação é uma tupla (operador, número1, número2)
        var fila = new List<(string, long, long)> {
            ("-", 14, 8),
            ("*", 5, 6), 
            ("+", 2147483647L, 2L),
            ("/", 18, 3)
        };

        var resultados = new List<long>();
        int index = 0;
        
        // Execulta enquanto ainda existirem operações na fila
        while (index < fila.Count)
        {   // Desestrutura a tupla: pega operador, número1 e número2
            var (op, n1, n2) = fila[index];

        // Calcula o resultado usando expressão switch
            long res = op switch
            {
                "+" => n1 + n2,
                "-" => n1 - n2,
                "*" => n1 * n2,
                "/" => n2 == 0 ? 0 : n1 / n2,
                _ => 0
            };

            Console.WriteLine($"Operação realizada: {n1} {op} {n2} = {res}");
            // Armazena o resultado na lista de resultados
            resultados.Add(res);

            // Próximas operações
            Console.Write("Fila restante: ");
            for (int i = index + 1; i < fila.Count; i++)
                Console.Write($"{fila[i].Item2}{fila[i].Item1}{fila[i].Item3} | ");
            Console.WriteLine("\n");

            index++;
        }
        
        Console.WriteLine("Resultados:");
        foreach (var r in resultados) 
            Console.WriteLine(r);
    }
}