using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterUpdateDto
{
    public string? Name { get; set; }
    public string? Thumbnail { get; set; }
    public CharacterSheet? Sheet { get; set; }

    public string? PlayerId { get; set; }
    public string? CampaignId { get; set; }
    public bool? IsActive { get; set; }
}