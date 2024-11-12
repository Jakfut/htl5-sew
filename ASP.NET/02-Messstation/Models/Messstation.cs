using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _02_Messstation.Models;

public class Messstation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Betriebsdauer { get; set; }
    
    public List<Messwert> Messwerte { get; set; } = new List<Messwert>();
}