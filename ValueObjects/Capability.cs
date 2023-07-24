using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.ValueObjects;

public record Capability(
    string Name,
    Ability Ability,
    int Modifier);  