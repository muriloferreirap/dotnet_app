using System;
using System.Diagnostics;
using System.IO;

public class Program
{
    public static void Main()
    {
        Process[] proc = Process.GetProcesses();

        string path = @"C:/PATHARQUIVO.txt";

        using (StreamWriter writer = File.CreateText(path))
        {
            foreach (Process p in proc)
            {
                writer.WriteLine(p.ProcessName);
            }
        }

        Console.WriteLine("Nomes salvos com sucesso, verifique o caminho e o arquivo txt criado.")
        Console.ReadLine();
    }
}
