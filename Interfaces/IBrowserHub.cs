using DiceDragon.Shared.DataTransferObjects.Campaigns;
using DiceDragon.Shared.DataTransferObjects.Characters;
using DiceDragon.Shared.DataTransferObjects.Rolls;

namespace DiceDragon.Shared.Interfaces;
public interface IBrowserHub
{
    Task UpdateCampaign(CampaignUpdateDto campaign);
    Task UpdateCharacter(string id, CharacterUpdateDto character);
    Task UpdateRoll(RollUpdateDto roll);
}