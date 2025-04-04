namespace FabricacionPiezas;
public interface IElementoConNombre
{
    string GetNombre();
}

public class Fabricante
{
    private static long _numeroDeSerie = 0;
    private List<Pieza> _piezas;
    public string Nombre { get; set; }
    public List<Pieza> Piezas => _piezas;
    public Fabricante(string nombre)
    {
        Nombre = nombre;
        _piezas = new List<Pieza>();
    }
    public Pieza CreatePieza()
    {
        string piezaNombre = _numeroDeSerie.ToString() + "-" + Nombre;
        Pieza pieza = new Pieza(this, piezaNombre);
        Piezas.Add(pieza);
        return pieza;
    }
    public long ProximoNumeroSerie()
    {
        return ++_numeroDeSerie;
    }
}

public class Pieza : IElementoConNombre
{
    private Fabricante _fabricante;
    public long NumeroSerie { get; set; }
    public string Nombre { get; set; }
    public Pieza(Fabricante fabricante, string nombre)
    {
        NumeroSerie = fabricante.ProximoNumeroSerie();
        Nombre = nombre;
        _fabricante = fabricante;
    }
    public string GetNombre()
    {
        return Nombre;
    }
}

