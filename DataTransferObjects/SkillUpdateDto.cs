namespace DiceDragon.Shared.DataTransferObjects;

public class SkillUpdateDto
{
    public required string Name { get; set; }
    public required string Ability { get; set; }
    public int Modifier { get; set; }
    public int Proficiency { get; set; }
}