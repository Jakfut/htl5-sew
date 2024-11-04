using _02_Messstation.Models;

namespace _02_Messstation.DTOs;

public record GetMesswertDto(int Id, int Wert, string Einheit, int MessstationId)
{
    
}

public static class GetMesswertMapper
{
    public static GetMesswertDto Map(Messwert messwert)
    {
        return new GetMesswertDto(messwert.Id, messwert.Wert, messwert.Einheit, messwert.MessstationId);
    }
    
    public static IEnumerable<GetMesswertDto> Map(IEnumerable<Messwert> messwerte)
    {
        return messwerte.Select(Map);
    }
}