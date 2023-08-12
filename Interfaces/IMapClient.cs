using DiceDragon.Shared.DataTransferObjects;

namespace DiceDragon.Shared.Interfaces;

public interface IMapClient
{
    Task MapUpdated(MapDto map);
    Task MapTilesUpdated(IEnumerable<MapTileDto> mapTiles);
    Task CharactersUpdated(IEnumerable<CharacterDto> characters);

    Task MessageReceived(string text);
}