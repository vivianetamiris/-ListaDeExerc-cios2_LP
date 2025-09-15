using System;
using minhaBiblioteca;

class Atividade3
{
    static int getEqu(int[,] matriz, int equ)
    {
        int contEqu = 0;
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == equ)
                {
                    contEqu++;
                }
            }
        }

        return contEqu;
    }

    static void Main()
    {
        int linhas, cols;
        Console.WriteLine("Entre com a quantidade de linhas e colunas: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, cols];

        Biblioteca.gerarMatriz(matriz);
        Biblioteca.escreverMatriz(matriz);

        Console.WriteLine("Digite o valor que você deseja procurar na matriz: ");
        int equ = int.Parse(Console.ReadLine());

        int qtd = getEqu(matriz, equ);
        Console.WriteLine($"O número {equ} aparece {qtd} vezes na matriz.");
    }
}