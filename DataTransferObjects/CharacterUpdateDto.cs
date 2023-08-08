using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CharacterUpdateDto
{
    // TODO make properties nullable? (except Id)

    public required string Id { get; set; }
    public required string Name { get; set; }

    public required string PlayerId { get; set; }
    public required string CampaignId { get; set; }
    public string? Thumbnail { get; set; }

    public CharacterSheet? Sheet { get; set; }
    public bool IsActive { get; set; }
}