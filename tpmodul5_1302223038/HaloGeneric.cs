using System;

public class HaloGeneric
{
    public void SapaUser<T>()
    {
        Console.Write("Nama praktikan: ");
        T input = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        Console.WriteLine($"Halo user {input}");
    }
}
