using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Characters;

public class CharacterUpdateDto
{
    public string? Name { get; set; }
    public bool? IsActive { get; set; }

    public int? CampaignId { get; set; }
    public string? PlayerId { get; set; }
    public string? Thumbnail { get; set; }

    public CharacterSheet? Sheet { get; set; }
    public MapPosition? Position { get; set; }
}