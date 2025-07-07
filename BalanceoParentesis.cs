using System;
using System.Collections.Generic;

class VerificarBalanceo
{
    /// <summary>
    /// Verifica si los paréntesis, llaves y corchetes están balanceados.
    /// </summary>
    public static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c); // Se apilan los caracteres de apertura
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0) return false;

                char tope = pila.Pop(); // Se desapilan para verificar coincidencia

                if ((c == ')' && tope != '(') ||
                    (c == ']' && tope != '[') ||
                    (c == '}' && tope != '{'))
                {
                    return false; // Desbalance encontrado
                }
            }
        }

        return pila.Count == 0; // Si la pila queda vacía, está balanceado
    }

    static void Main()
    {
        Console.Write("Ingrese la expresión con paréntesis, corchetes, etc: ");
        string expresion = Console.ReadLine();

        if (EstaBalanceado(expresion))
            Console.WriteLine("✅ Fórmula balanceada.");
        else
            Console.WriteLine("❌ Fórmula desbalanceada.");
    }
}
