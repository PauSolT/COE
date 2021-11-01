using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Character
{
    PlayerModel playerModel = null;
    public override void Init()
    {
        playerModel = new PlayerModel();
        UnlockElement(ElemName.fire, new Fire());

        MaxHealth = playerModel.MaxStartingHealth;
        Health = 50f;

        playerModel.CurrentElement = playerModel.Elements[ElemName.fire];
        PlayerView playerView = Object.Instantiate(new PlayerView());
        playerView.Init();

    }

    private void InitElements(ElemName elemName)
    {
        playerModel.Elements[elemName].Init();
    }

    public void UseAbility(AbilityCode abilityCode, List<Character> characters)
    {
        playerModel.CurrentElement.AbilityUse(abilityCode, characters);
    }

    public void UnlockElement(ElemName elemName, Element elem)
    {
        playerModel.Elements.Add(elemName, elem);
        InitElements(elemName);
    }

    public void GainAbilityMeter(float addMeter)
    {
        if (playerModel.AbilityMeter < playerModel.MaxAbilityMeter)
        {
            playerModel.AbilityMeter += addMeter * playerModel.AbilityMeterMultiplier;
        }
    }



}