# 🧠 Teste Técnico - Back-end .NET Júnior (2026)

## 📌 Objetivo

Este repositório contém a resolução das questões propostas no teste técnico para a vaga de Desenvolvedor(a) Back-end .NET Júnior.

O foco da solução foi demonstrar:

* Raciocínio lógico
* Organização de código
* Clareza na implementação
* Aplicação de boas práticas

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET
* SQL Server (conceitual)
* Git / GitHub

---

# 📚 Questões Resolvidas

---

## 🔹 Questão 1 - Verificação de Palíndromo

### ✔ Descrição

Identificar se uma string é um palíndromo, ignorando espaços, caracteres especiais e diferenças entre maiúsculas e minúsculas.

### 🧠 Abordagem

* Normalização da string (remoção de caracteres inválidos)
* Conversão para minúsculo
* Uso da técnica de dois ponteiros para comparação

### 💻 Destaque técnico

* Não foi utilizado o método `Reverse()`
* Foco em performance e legibilidade

---

## 🔹 Questão 2 - Geração da Sequência de Fibonacci

### ✔ Descrição

Gerar os X primeiros números da sequência de Fibonacci.

### 🧠 Abordagem

* Inicialização com os dois primeiros valores (0 e 1)
* Uso de loop para calcular os próximos valores

### 💻 Destaque técnico

* Tratamento de casos de borda (0 e 1)
* Estrutura simples e eficiente

---

## 🔹 Questão 3 - Normalização de Texto com Pontuação

### ✔ Descrição

Remover repetições consecutivas de sinais de exclamação (!) e interrogação (?) em uma string.

### 🧠 Abordagem

* Percorrer a string caractere por caractere
* Comparar com o caractere anterior
* Ignorar repetições

### 💻 Destaque técnico

* Uso de `StringBuilder` para melhor performance
* Solução simples e eficiente

---

## 🔹 Questão 4 - Conceitos de Banco de Dados

### ✔ Descrição

Explicação dos conceitos de:

* View
* Table-valued Function
* Stored Procedure
* Trigger

### 🧠 Abordagem

* Explicação teórica
* Exemplos práticos em SQL

### 💻 Destaque técnico

* Diferenciação clara entre cada conceito
* Aplicação em cenários reais

---

## 🔹 Questão 5 - Procedure de Finalização de Orçamento

### ✔ Descrição

Criação de uma stored procedure para finalizar um orçamento.

### 🧠 Regras implementadas

* Verificação de existência do orçamento
* Validação de status (Aberto)
* Verificação de itens
* Cálculo do valor total
* Atualização de status e data

### 💻 Destaque técnico

* Uso de validações antes da atualização
* Retorno de mensagens claras
* Organização do fluxo de execução

---

## 🔹 Questão 6 - Endpoint de Cadastro de Orçamento (API .NET)

### ✔ Descrição

Criação de um endpoint para cadastro de orçamento com validações.

### 🧠 Regras implementadas

* Validação de clienteId e veiculoId
* Validação dos itens
* Cálculo do valor total
* Retorno de erros claros

### 💻 Destaque técnico

* Uso de DTOs para organização
* Validação completa de entrada
* Estrutura de API REST

---

## ⚙️ Considerações Gerais

As soluções foram desenvolvidas com foco em:

* Código limpo e legível
* Separação de responsabilidades
* Facilidade de manutenção
* Clareza na explicação

Não foram utilizados frameworks ou estruturas complexas, priorizando a simplicidade e o entendimento das soluções.

---

## 🚀 Possíveis Melhorias

* Implementação de testes unitários
* Integração com banco de dados real
* Uso de camadas (Service/Repository)
* Tratamento global de exceções
* Aplicação de padrões de projeto

---

## 📌 Conclusão

Este teste foi desenvolvido com o objetivo de demonstrar não apenas conhecimento técnico, mas também organização, clareza e capacidade de resolução de problemas.

As soluções apresentadas seguem boas práticas e podem ser evoluídas para cenários reais de produção.

---
