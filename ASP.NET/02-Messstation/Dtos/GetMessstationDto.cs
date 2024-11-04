using _02_Messstation.Models;

namespace _02_Messstation.DTOs;

public record GetMessstationDto(int Id, string Name, int Betriebsdauer, IEnumerable<GetMesswertDto> Messwerte)
{
    
}

public static class MessstationMapper
{
    public static GetMessstationDto Map(Messstation messstation)
    {
        return new GetMessstationDto(messstation.Id, messstation.Name, messstation.Betriebsdauer,
            GetMesswertMapper.Map(messstation.Messwerte));
    }

    public static IEnumerable<GetMessstationDto> Map(IEnumerable<Messstation> messstation)
    {
        return messstation.Select(Map);
    }
}