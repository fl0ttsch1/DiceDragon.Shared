namespace DiceDragon.Shared.DataTransferObjects;

public class SavingThrowUpdateDto
{
    public required string Ability { get; set; }
    public int Modifier { get; set; }
    public int Proficiency { get; set; }
}