using System;

class Program
{
    static void Main(string[] args)
    {

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Arga");

        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302223038");
        dataGeneric.PrintData();

    }
}
