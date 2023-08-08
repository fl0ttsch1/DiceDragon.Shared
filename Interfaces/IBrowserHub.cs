using DiceDragon.Shared.DataTransferObjects;

namespace DiceDragon.Shared.Interfaces;
public interface IBrowserHub
{
    Task UpdateCampaign(CampaignUpdateDto campaign);
    Task UpdateCharacter(CharacterUpdateDto character);
    Task UpdateRoll(RollUpdateDto roll);
}