using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterUpdateDto
{
    // TODO make properties nullable (except Id)

    public required string Id { get; set; }

    public string Name { get; set; }
    public string? Thumbnail { get; set; }

    public required string Race { get; set; }   // TODO fetch from api?
    public required string Classes { get; set; }
    public int ProficiencyBonus { get; set; }

    public int MovementSpeed { get; set; }
    public int ArmorClass { get; set; }
    public int Initiative { get; set; }
    public required HitPoints HitPoints { get; set; }

    public required List<AbilityScoreUpdateDto> AbilityScores { get; set; }
    public required List<SavingThrowUpdateDto> SavingThrows { get; set; }
    public required List<SkillUpdateDto> Skills { get; set; }
}