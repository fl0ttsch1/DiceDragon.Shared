using DiceDragon.Shared.DataTransferObjects.Characters;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

// TODO background color/image

public class MapDto
{
    public int Id { get; set; }
    public int CampaignId { get; set; }
    public bool IsActive { get; set; }

    public required string Name { get; set; }
    public required Dimensions Bounds { get; set; }
    public DimensionsF? ViewBox { get; set; }

    //public required List<MapRoomDto> Rooms { get; set; }
    //public required List<MapTileDto> Tiles { get; set; }

    public required List<CharacterDto> Characters { get; set; }
}