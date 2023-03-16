using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            for (int j = 0; j <= 255; j++)
            {
                for (int k = 0; k <= 255; k++)
                {
                    for (int l = 0; l <= 255; l++)
                    {
                        string ip = $"{i}.{j}.{k}.{l}";
                        Console.WriteLine(ip);
                        
                    }
                }
            }
        }
    }
}

