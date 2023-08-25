using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.DataTransferObjects.Maps;

public record MapCreationDto(
    int CampaignId,
    string Name,
    DimensionsF ViewBox);