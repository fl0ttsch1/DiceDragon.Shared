using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsActive { get; set; }

    public int? CampaignId { get; set; }
    public string? PlayerId { get; set; }
    public string? ThumbnailUrl { get; set; }

    public CharacterSheet? Sheet { get; set; }
    public MapPosition? Position { get; set; }
}