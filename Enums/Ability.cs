using System.ComponentModel.DataAnnotations;

namespace DiceDragon.Shared.Enums;

public enum Ability
{
    [Display(ShortName = "STR")]
    Strength = 0,

    [Display(ShortName = "DEX")]
    Dexterity = 1,

    [Display(ShortName = "CON")]
    Constitution = 2,

    [Display(ShortName = "INT")]
    Intelligence = 3,

    [Display(ShortName = "WIS")]
    Wisdom = 4,

    [Display(ShortName = "CHA")]
    Charisma = 5
}