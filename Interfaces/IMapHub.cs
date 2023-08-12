using DiceDragon.Shared.DataTransferObjects;
using System.Drawing;

namespace DiceDragon.Shared.Interfaces;

public interface IMapHub
{
    Task<CampaignDto> SetCampaign(string campaignId);   // TODO make nullable?
    Task SetViewBox(Rectangle rectangle);
}