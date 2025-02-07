namespace Web_Intro.DTOs;

public record struct UpdateUserDTO
{
	public string Name { get; set; }
	public string Surname { get; set; }
}
