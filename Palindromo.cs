using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(EhPalindromo("Arara")); // true
        Console.WriteLine(EhPalindromo("Ovo")); // true
        Console.WriteLine(EhPalindromo("Roma me tem amor")); // true
        Console.WriteLine(EhPalindromo("Teste")); // false
    }

    public static bool EhPalindromo(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return false;

        string tratado = "";

        foreach (char c in texto)
        {
            if (char.IsLetterOrDigit(c))
            {
                tratado += char.ToLower(c);
            }
        }

        int inicio = 0;
        int fim = tratado.Length - 1;

        while (inicio < fim)
        {
            if (tratado[inicio] != tratado[fim])
                return false;

            inicio++;
            fim--;
        }

        return true;
    }
}
