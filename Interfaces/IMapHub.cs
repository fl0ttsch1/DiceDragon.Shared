using DiceDragon.Shared.DataTransferObjects.Campaigns;
using DiceDragon.Shared.ValueObjects;

namespace DiceDragon.Shared.Interfaces;

public interface IMapHub
{
    Task<CampaignDto> SetCampaign(int campaignId);
    Task SetViewBox(DimensionsF viewBox);
}