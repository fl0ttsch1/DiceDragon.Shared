﻿using DiceDragon.Shared.Enums;

namespace DiceDragon.Shared.ValueObjects;

public class Skill
{
    public required string Name { get; set; }
    public int Modifier { get; set; }
    public Proficiency Proficiency { get; set; }
}