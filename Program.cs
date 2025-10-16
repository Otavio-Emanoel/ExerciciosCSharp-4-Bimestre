public class Program
{
    public static void Main()
    {
        Console.WriteLine("Seja bem vindo à lista de exercicios do Otavio e do Samuel\n");
        while (true) 
        {
            Console.WriteLine("Digite qual exercicio voce deseja visualizar: \n");
            string inputSelect = Console.ReadLine();
            if (inputSelect == null) 
            {
                return;
            }
            if (inputSelect == "1")
            {
                Exercicio1();
            }
            else if (inputSelect == "2")
            {
                Exercicio2();
            }
            else if (inputSelect == "3")
            {
                Exercicio3();
            }
            else if (inputSelect == "4")
            {
                Exercicio4();
            }
            else if (inputSelect == "5")
            {
                Exercicio5();
            }
            else if (inputSelect == "6")
            {
                Exercicio6();
            }
            else if (inputSelect == "7")
            {
                Exercicio7();
            }
            else if (inputSelect == "8")
            {
                Exercicio8();
            }
            else if (inputSelect == "9")
            {
                Exercicio9();
            }
            else if (inputSelect == "10")
            {
                Exercicio10();
            }
        }
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
        Console.WriteLine("Programa de pagamento de comissão");
        try
        {
            Console.Write("Digite a identificação do vendedor: ");
            string identificacaoVendedor = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(identificacaoVendedor))
            {
                Console.WriteLine("Identificação não pode ser vazia. Tente novamente:");
                identificacaoVendedor = Console.ReadLine();
            }

            Console.Write("Digite o código da peça: ");
            string codigoPeca = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(codigoPeca))
            {
                Console.WriteLine("Código da peça não pode ser vazio. Tente novamente:");
                codigoPeca = Console.ReadLine();
            }

            decimal precoUnitario = 0;
            while (precoUnitario <= 0)
            {
                Console.Write("Digite o preço unitário da peça: ");
                string inputPreco = Console.ReadLine();
                if (decimal.TryParse(inputPreco, out precoUnitario) && precoUnitario > 0)
                    break;
                Console.WriteLine("Preço inválido! Tente novamente.");
            }

            int quantidadeVendida = 0;
            while (quantidadeVendida <= 0)
            {
                Console.Write("Digite a quantidade vendida: ");
                string inputQtd = Console.ReadLine();
                if (int.TryParse(inputQtd, out quantidadeVendida) && quantidadeVendida > 0)
                    break;
                Console.WriteLine("Quantidade inválida! Tente novamente.");
            }

            decimal totalVenda = precoUnitario * quantidadeVendida;
            decimal comissao = totalVenda * 0.05m;

            Console.WriteLine($"\nResumo da venda:");
            Console.WriteLine($"Vendedor: {identificacaoVendedor}");
            Console.WriteLine($"Código da peça: {codigoPeca}");
            Console.WriteLine($"Total da venda: R$ {totalVenda:F2}");
            Console.WriteLine($"Comissão (5%): R$ {comissao:F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio3()
    {
        Console.WriteLine("Calculador de estoque");
        try
        {
            int quantidadeMinima = 0;
            int quantidadeMaxima = 0;

            while (quantidadeMinima <= 0)
            {
                Console.Write("Digite a quantidade mínima da peça (maior que zero): ");
                string inputMin = Console.ReadLine();
                if (int.TryParse(inputMin, out quantidadeMinima) && quantidadeMinima > 0)
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            while (quantidadeMaxima <= 0)
            {
                Console.Write("Digite a quantidade máxima da peça (maior que zero): ");
                string inputMax = Console.ReadLine();
                if (int.TryParse(inputMax, out quantidadeMaxima) && quantidadeMaxima > 0)
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2.0;
            Console.WriteLine($"O estoque médio da peça é: {estoqueMedio}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio4()
    {
        Console.WriteLine("Exibidor de módulo");
        try
        {
            int numero;
            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numero))
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            int modulo = numero >= 0 ? numero : numero * -1;
            Console.WriteLine($"O módulo de {numero} é: {modulo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void Exercicio5()
    {
        Console.WriteLine("Exibidor de numeros inteiros em ordem decescente");
        try
        {
            int[] numeros = new int[3];
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Digite o {i + 1}º número inteiro: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out numeros[i]))
                        break;
                    Console.WriteLine("Valor inválido! Tente novamente.");
                }
            }

            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine("Números em ordem decrescente:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public static void Exercicio6()
    {
        Console.WriteLine("Diferença entre numeros");
        try
        {
            int numero1, numero2;

            while (true)
            {
                Console.Write("Digite o primeiro número inteiro: ");
                string input1 = Console.ReadLine();
                if (int.TryParse(input1, out numero1))
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            while (true)
            {
                Console.Write("Digite o segundo número inteiro: ");
                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out numero2))
                    break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            int maior = Math.Max(numero1, numero2);
            int menor = Math.Min(numero1, numero2);
            int diferenca = maior - menor;

            Console.WriteLine($"A diferença do maior para o menor é: {diferenca}");
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
            int num1, num2;

            while (true)
            {
                Console.Write("Digite o primeiro número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out num1)) break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            while (true)
            {
                Console.Write("Digite o segundo número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out num2)) break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            if (num1 == num2)
            {
                Console.WriteLine("Os dois números são iguais!");
            }
            else
            {
                int maior = Math.Max(num1, num2);
                int menor = Math.Min(num1, num2);
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número é: {menor}");
            }
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
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 – Adição");
            Console.WriteLine("2 – Subtração");
            Console.WriteLine("3 – Multiplicação");
            Console.WriteLine("4 – Divisão");

            int escolha = 0;
            while (escolha < 1 || escolha > 4)
            {
                Console.Write("Digite a opção desejada (1 a 4): ");
                int.TryParse(Console.ReadLine(), out escolha);
            }

            double num1, num2;
            while (true)
            {
                Console.Write("Digite o primeiro número: ");
                if (double.TryParse(Console.ReadLine(), out num1)) break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }
            while (true)
            {
                Console.Write("Digite o segundo número: ");
                if (double.TryParse(Console.ReadLine(), out num2)) break;
                Console.WriteLine("Valor inválido! Tente novamente.");
            }

            switch (escolha)
            {
                case 1:
                    Console.WriteLine($"Resultado da adição: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado da subtração: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado da multiplicação: {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                        Console.WriteLine("Não é possível dividir por zero.");
                    else
                        Console.WriteLine($"Resultado da divisão: {num1 / num2}");
                    break;
            }
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
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
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
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
            }
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
