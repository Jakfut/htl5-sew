namespace _02_Messstation.Models;

public class Messwert
{
    public int Id { get; set; }
    public int Wert { get; set; }
    public string Einheit { get; set; }
    
    // Foreign Key
    public int MessstationId { get; set; }
    public Messstation? Messstation { get; set; } = default!;
}