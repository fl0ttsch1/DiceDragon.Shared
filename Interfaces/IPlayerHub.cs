﻿using DiceDragon.Shared.DataTransferObjects.Characters;
using DiceDragon.Shared.DataTransferObjects.Players;

namespace DiceDragon.Shared.Interfaces;

public interface IPlayerHub
{
    Task<bool> Authenticate(string accessToken);
    Task<IEnumerable<CharacterDto>> GetCharacters();
    Task<PlayerDto?> GetPlayer();
}