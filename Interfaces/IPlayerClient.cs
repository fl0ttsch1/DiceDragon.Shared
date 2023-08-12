using DiceDragon.Shared.DataTransferObjects;

namespace DiceDragon.Shared.Interfaces;

public interface IPlayerClient
{
    Task CharacterUpdated(CharacterDto character);
}