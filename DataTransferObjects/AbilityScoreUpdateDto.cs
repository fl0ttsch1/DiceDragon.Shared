namespace DiceDragon.Shared.DataTransferObjects;

public class AbilityScoreUpdateDto
{
    public required string Name { get; set; }
    public required string Abbreviation { get; set; }
    public int Score { get; set; }
}