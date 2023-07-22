using DiceDragon.Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DiceDragon.Shared.Extensions;
public static class AbilityExtensions
{
    public static string GetLongName(this Ability ability)
    {
        var displayAttribute = GetDisplayAttribute(ability);
        return displayAttribute?.Name ?? ability.ToString();
    }

    public static string GetShortName(this Ability ability)
    {
        var displayAttribute = GetDisplayAttribute(ability);
        return displayAttribute?.ShortName ?? GetLongName(ability);
    }

    private static DisplayAttribute? GetDisplayAttribute(Ability ability)
    {
        return typeof(Ability)
            .GetMember(ability.ToString())?
            .SingleOrDefault()?
            .GetCustomAttribute<DisplayAttribute>();
    }
}