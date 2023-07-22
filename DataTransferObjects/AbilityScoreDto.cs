namespace DiceDragon.Shared.DataTransferObjects;

public class AbilityScoreDto
{
    public string Name { get; set; }
    public int Score { get; set; }
    public int Modifier { get; set; }
    public int SavingThrow { get; set; }
    public List<SkillDto> Skills { get; set; }
}