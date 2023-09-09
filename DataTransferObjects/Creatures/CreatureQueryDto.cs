using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Creatures;

public class CreatureQueryDto
{
    public int? CampaignId { get; set; }
    public int? MapId { get; set; }
    public string? PlayerId { get; set; }

    public bool? IsDisabled { get; set; }
    public bool? CanMove { get; set; }
    public bool? IsDead { get; set; }

    public SizeType? SizeType { get; set; }
}