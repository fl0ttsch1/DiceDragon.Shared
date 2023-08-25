using DiceDragon.Shared.DataTransferObjects.Maps;

namespace DiceDragon.Shared.Interfaces;

public interface IMapClient
{
    Task MapUpdated(MapDto map);
    Task MessageReceived(string text);
}