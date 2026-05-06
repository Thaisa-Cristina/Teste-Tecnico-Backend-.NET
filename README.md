# 🧠 Teste Técnico - Backend .NET Júnior

## 📌 Questão 1 - Verificação de Palíndromo

### 📖 Descrição do Problema

Desenvolver um método que identifique se uma string é um palíndromo.

Um palíndromo é uma palavra ou frase que pode ser lida da mesma forma de trás para frente, desconsiderando espaços, pontuação e diferenças entre letras maiúsculas e minúsculas.

### ✔ Exemplos válidos:
- Arara → true
- Ovo → true
- Roma me tem amor → true
- O lobo ama o bolo → true

### ❌ Exemplos inválidos:
- Teste → false

---

## 🛠️ Abordagem Utilizada

A solução foi construída sem utilizar métodos prontos como `Reverse()`, conforme solicitado.

O processo foi dividido em etapas:

### 1. Normalização da String
- Remoção de caracteres que não são letras ou números
- Conversão de todos os caracteres para minúsculo

Isso garante que frases com espaços e variações de escrita sejam tratadas corretamente.

---

### 2. Estrutura de Dados
Foi utilizada uma lista de caracteres (`List<char>`) para armazenar os caracteres válidos da string.

Essa abordagem evita o uso de concatenação de strings dentro de loops, o que pode impactar negativamente a performance.

---

### 3. Verificação com Dois Ponteiros

Foi utilizada a técnica de dois ponteiros:

- Um ponteiro inicia no começo da lista
- Outro ponteiro inicia no final

Os caracteres são comparados enquanto os ponteiros avançam:

- Se todos os caracteres forem iguais → é palíndromo
- Se houver diferença → não é palíndromo

---

## 💻 Implementação

```csharp
public static bool EhPalindromo(string texto)
{
    if (string.IsNullOrEmpty(texto))
        return false;

    var caracteres = new List<char>();

    foreach (char c in texto)
    {
        if (char.IsLetterOrDigit(c))
        {
            caracteres.Add(char.ToLower(c));
        }
    }

    int inicio = 0;
    int fim = caracteres.Count - 1;

    while (inicio < fim)
    {
        if (caracteres[inicio] != caracteres[fim])
            return false;

        inicio++;
        fim--;
    }

    return true;
}


🧪 Exemplos de Teste
Console.WriteLine(EhPalindromo("Arara")); // true
Console.WriteLine(EhPalindromo("Ovo")); // true
Console.WriteLine(EhPalindromo("Roma me tem amor")); // true
Console.WriteLine(EhPalindromo("Teste")); // false


## 🧠 Explicação resumida

A solução utiliza a técnica de dois ponteiros, comparando os caracteres do início e do fim da string após normalização, garantindo uma verificação eficiente sem uso de métodos prontos como Reverse().
