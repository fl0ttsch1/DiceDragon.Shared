namespace DiceDragon.Shared.DataTransferObjects;

public class AbilityScoreUpdateDto
{
    public required string Ability { get; set; }
    public required string Abbreviation { get; set; }
    public int Score { get; set; }
}