using System;
using minhaBiblioteca;

class Atividade8
{
    static int contarRaiosMesmoLocal(int[,] matriz)
    {
        int cont = 0;

        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] > 1)
                {
                    cont++;
                }

            }
        }

        return cont;
        
    }


    static void Main()
    {
        int x, y, quantidadeRaios, linhas, cols;

        Console.WriteLine("Quantidade de linhas e colunas da área: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());

        int[,] mapa = new int[linhas, cols];

        Console.Write("Quantos raios foram anotados: ");
        quantidadeRaios = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.Write("Coordenadas que o raio caiu: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x, y]++;
        }

        Biblioteca.mostrarMatriz(mapa);

        Console.WriteLine("Número de locais onde houve mais de uma ocorrência de raios: " + contarRaiosMesmoLocal(mapa));

    }
}