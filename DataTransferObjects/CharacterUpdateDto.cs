using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterUpdateDto
{
    public string? Name { get; set; }
    public Uri? Thumbnail { get; set; }

    public string? PlayerId { get; set; }
    public int? CampaignId { get; set; }
    public bool? IsActive { get; set; }

    public CharacterSheet? Sheet { get; set; }
    public MapPosition? Position { get; set; }
}