namespace _02_Messstation.DTOs;

public record PostMesswertDto(int Wert, string Einheit)
{
    
}

public static class PostMesswertMapper
{
    public static PostMesswertDto Map(PostMesswertDto postMesswertDto)
    {
        return new PostMesswertDto(postMesswertDto.Wert, postMesswertDto.Einheit);
    }
}