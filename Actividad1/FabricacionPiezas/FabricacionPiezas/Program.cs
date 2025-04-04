namespace FabricacionPiezas;

public class Program
{
    public static void Main(string[] args)
    {
        Fabricante fabricante = new Fabricante("Ferrari");

        LoadPiezas(fabricante);

        IterateThroughPiezas(fabricante);
        
        AnotherWayToIterateThroughPiezas(fabricante);
    }

    private static void LoadPiezas(Fabricante fabricante)
    {
        for (int i = 1; i <= 5; i++)
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

    public static void AnotherWayToIterateThroughPiezas(Fabricante fabricante)
    {
        foreach (Pieza elemento in fabricante.Piezas)
        {
            Console.WriteLine(elemento.GetNombre());
        }
    }
}