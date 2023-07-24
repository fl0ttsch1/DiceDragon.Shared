using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterDto
{
    public required string Id { get; set; }
    public required string Name { get; set; }

    public string? ThumbnailUrl { get; set; }
    public string? PlayerId { get; set; }
    public string? CampaignId { get; set; }

    public CharacterSheet? Sheet { get; set; }
}