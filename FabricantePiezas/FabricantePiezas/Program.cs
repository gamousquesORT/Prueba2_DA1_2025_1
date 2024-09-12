namespace FabricantePiezas;


public class Program
{
    public static void Main(string[] args)
    {
        Fabricante fabricante = new Fabricante("Ferrari");

        LoadPiezas(fabricante);

        IterateThroughPiezas(fabricante);
    }

    private static void LoadPiezas(Fabricante fabricante)
    {
        for (int i = 0; i < 5; i++)
        {
            fabricante.CreatePieza();
        }
    }

    public static void IterateThroughPiezas(Fabricante fabricante)
    {
        foreach (IElementoConNombre elemento in fabricante.Piezas)
        {
            Console.WriteLine(elemento.GetNombre());
        }
    }

}