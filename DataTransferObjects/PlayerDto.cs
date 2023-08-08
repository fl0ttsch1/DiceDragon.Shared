namespace DiceDragon.Shared.DataTransferObjects;

public class PlayerDto
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required List<CharacterDto> Characters { get; set; }
}