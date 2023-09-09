using DiceDragon.Shared.DataTransferObjects.Characters;
using DiceDragon.Shared.DataTransferObjects.Maps;
using DiceDragon.Shared.DataTransferObjects.Rolls;

namespace DiceDragon.Shared.Interfaces;

public interface IMapClient
{
    Task CharacterUpdated(CharacterDto character);
    Task MapUpdated(MapDto map);
    Task Roll(RollCreationDto roll);
}