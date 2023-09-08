using DiceDragon.Shared.DataTransferObjects.Characters;
using DiceDragon.Shared.DataTransferObjects.MapRooms;
using DiceDragon.Shared.DataTransferObjects.MapTiles;
using DiceDragon.Shared.DataTransferObjects.Monsters;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public class MapDto
{
    // TODO set object-fit (cover by default?)

    public int Id { get; set; }
    public int CampaignId { get; set; }
    public bool IsActive { get; set; }

    public required string Name { get; set; }
    public required RectangleF Bounds { get; set; }

    public int? BackgroundId { get; set; }
    public string? BackgroundUrl { get; set; }
    public string? BackgroundColor { get; set; }
    public RectangleF? ViewBox { get; set; }

    public required List<MapRoomDto> Rooms { get; set; }
    public required List<MapTileDto> Tiles { get; set; }

    public required List<CharacterDto> Characters { get; set; }
    public required List<MonsterDto> Monsters { get; set; }
}