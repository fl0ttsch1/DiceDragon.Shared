using DiceDragon.Shared.DataTransferObjects;

namespace DiceDragon.Shared.Interfaces;

public interface IBrowserClient
{
    Task Roll(RollCreationDto roll);
}