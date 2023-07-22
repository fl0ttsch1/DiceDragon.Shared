namespace DiceDragon.Shared.DataTransferObjects;

public class CampaignDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<CampaignCharacterDto>? Characters { get; set; }
}