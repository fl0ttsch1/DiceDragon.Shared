using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterDto
{
    // TODO use int values instead of ProficiencyType?

    public string Id { get; set; }
    public string Name { get; set; }
    public string? ThumbnailUrl { get; set; }

    public string? PlayerId { get; set; }
    public string? CampaignId { get; set; }

    public CharacterSheet Sheet { get; set; }
}