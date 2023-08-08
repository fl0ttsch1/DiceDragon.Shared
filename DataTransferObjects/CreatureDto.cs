using DiceDragon.Shared.Enums;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects;

public class CreatureDto : TokenDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required HitPoints HitPoints { get; set; }
    public CreatureType CreatureType { get; set; }
    public Affiliation Affiliation { get; set; }
}