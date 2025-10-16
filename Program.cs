public class Program
{
    public static void Main()
    {
        Console.WriteLine("Seja bem vindo à lista de exercicios do Otavio e do Samuel\n");
        Exercicio1();
    }

    public static void Exercicio1()
    {
        Console.WriteLine("Conversor de Dólares para Reais");
        try
        {
            decimal cotacaoDolar = 0;
            while (cotacaoDolar == 0)
            {
                Console.Write("Digite a cotação do dólar (Sugerido 5,45): ");
                string inputCotacao = Console.ReadLine();
                if (decimal.TryParse(inputCotacao, out cotacaoDolar) && cotacaoDolar != 0)
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            decimal valorDolar = 0;
            while (valorDolar == 0)
            {
                Console.Write("Digite o valor em dólares para ser convertido em reais (não pode ser zero ou vazio): ");
                string inputValor = Console.ReadLine();
                if (decimal.TryParse(inputValor, out valorDolar) && valorDolar != 0)
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            decimal valorReais = valorDolar * cotacaoDolar;
            Console.WriteLine($"Valor em reais: R$ {valorReais:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio2()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio3() 
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio4()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio5()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Exercicio6()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Exercicio7()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Exercicio8()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Exercicio9()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Exercicio10()
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}

/*
    
    Exercícios em C#:
        1)	Faça um programa que: 
        - Leia a cotação do dólar 
        - Leia um valor em dólares 
        - Converta esse valor para Real 
        - Mostre o resultado

        2)	Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua comissão será de 5% do total da venda e que você tem os seguintes dados: 
        - Identificação do vendedor 
        - Código da peça 
        - Preço unitário da peça 
        - Quantidade vendida

        3)	Faça um programa para calcular o estoque médio de uma peça, sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

        4)	Escreva um programa que leia um número inteiro e exiba o seu módulo. 
        O módulo de um número x é: 
        x se x é maior ou igual a zero 
        x * (-1) se x é menor que zero

        5)	Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.

        6)	Escreva um programa que leia dois números e apresente a diferença do maior para o menor.

        7)	Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.

        8)	Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
        1 – Adição 
        2 – Subtração 
        3 – Multiplicação 
        4 – Divisão

        9)	Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.

        10)	Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".

*/