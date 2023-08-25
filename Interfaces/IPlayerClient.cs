using DiceDragon.Shared.DataTransferObjects.Characters;

namespace DiceDragon.Shared.Interfaces;

public interface IPlayerClient
{
    Task CharacterUpdated(CharacterDto character);
}