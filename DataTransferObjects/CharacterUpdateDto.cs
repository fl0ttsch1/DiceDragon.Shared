using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterUpdateDto
{
    // TODO move to separate project, share via nuget

    public string Id { get; set; }
    public string Name { get; set; }
    public string? Thumbnail { get; set; }

    public string Race { get; set; }
    public string Classes { get; set; }
    public int Proficiency { get; set; }

    public int Speed { get; set; }
    public int Initiative { get; set; }
    public int ArmorClass { get; set; }
    public HitPoints HitPoints { get; set; }

    public Dictionary<string, int> Abilities { get; set; }
    public List<SavingThrowUpdateDto> Saves { get; set; }
    public List<SkillUpdateDto> Skills { get; set; }
}