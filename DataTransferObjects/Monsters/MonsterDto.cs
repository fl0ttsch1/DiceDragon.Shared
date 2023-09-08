using DiceDragon.Shared.DataTransferObjects.Creatures;
using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.DataTransferObjects.Monsters;

public class MonsterDto : CreatureDto
{
    // TODO senses?
    // TODO immunities?
    // TODO abilities?

    public MonsterType MonsterType { get; set; }
    public int ChallengeRating { get; set; }
}