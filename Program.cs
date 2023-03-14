using System;
using System.Diagnostics;
using System.IO;

public class Program
{
    public static void Main()
    {
        Process[] proc = Process.GetProcesses();

        string path = @"C:\Users\Murilo\Documents\projetos\dotnet_app\FirstApp\process.txt";

        using (StreamWriter writer = File.CreateText(path))
        {
            foreach (Process p in proc)
            {
                writer.WriteLine($"Name: {p.ProcessName} Id: {p.Id}");
            }
        }

        Console.WriteLine("Nomes salvos com sucesso, verifique o caminho e o arquivo txt criado.");
        Console.ReadLine();
    }
}
