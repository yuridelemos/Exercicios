string[] value = Console.ReadLine().Split(' ');
int m = int.Parse(value[0]);
int n = int.Parse(value[1]);
int[,] matriz = new int[m, n];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    value = Console.ReadLine().Split(' ');
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = int.Parse(value[j]);
    }
}

int selector = int.Parse(Console.ReadLine());

for (int i = 0; i <m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matriz[i, j] == selector)
        {
            Console.WriteLine("Position: {0},{1}", i, j);
            
            if(j > 0)
                Console.WriteLine("Left: " + matriz[i, j - 1]);
            if(j < n - 1)
                Console.WriteLine("Right: " + matriz[i, j + 1]);
            if(i > 0)
                Console.WriteLine("Up: " + matriz[i - 1, j]);
            if (i < m - 1)
                Console.WriteLine("Down:  " + matriz[i + 1, j]);
        }
    }
}