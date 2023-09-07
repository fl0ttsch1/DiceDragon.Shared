using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Monsters;
public class MonsterCreationDto
{
    // TODO int? TemplateId
    // TODO properties from monsterDto

    public string? Name { get; set; }
    public int? ThumbnailId { get; set; }
    public int? MovementSpeed { get; set; }
    public int? Intiative { get; set; }
    public int? ArmorClass { get; set; }
    public int? TotalHitPoints { get; set; }

    public HitPoints? HitPoints { get; set; }
}