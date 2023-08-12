namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterTokenDto : TokenBaseDto
{
    public required string Id { get; set; }
    public required string Name { get; set; }
}