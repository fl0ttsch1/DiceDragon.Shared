using DiceDragon.Shared.DataTransferObjects.Rolls;

namespace DiceDragon.Shared.Interfaces;

public interface IBrowserClient
{
    Task Roll(RollCreationDto roll);
}