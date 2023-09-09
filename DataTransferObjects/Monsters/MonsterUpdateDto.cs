using DiceDragon.Shared.DataTransferObjects.Creatures;
using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Monsters;

public class MonsterUpdateDto : CreatureUpdateDto
{
    public MonsterType? MonsterType { get; set; }
    public int? ChallengeRating { get; set; }
}