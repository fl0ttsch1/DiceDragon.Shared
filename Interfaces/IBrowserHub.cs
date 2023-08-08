using DiceDragon.Shared.DataTransferObjects;

namespace DiceDragon.Shared.Interfaces;
public interface IBrowserHub
{
    Task UpdateCampaign(CampaignUpdateDto campaign);
    Task UpdateCharacter(string id, CharacterUpdateDto character);
    Task UpdateRoll(RollUpdateDto roll);
}