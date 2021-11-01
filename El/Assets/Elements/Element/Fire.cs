using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fire : Element
{
    public override void Init()
    {
        ElementName = ElemName.fire;
        InitAbility1();
        InitAbility2();
        InitAbility3();
    }

    /// <summary>
    /// ABILITY 1 FIRE
    /// Fireball
    /// </summary>
    private void InitAbility1()
    {
        Ability ability = new Ability();
        ability.AbiltyName = "FIRE 1";
        ability.Damage = 10f;
        ability.AbilityCode = AbilityCode.Ability1;
        abilitiesElement.Add(ability);
        abilitiesElement[0].AbilityUse = Ability1;
    }

    private void InitAbility4()
    {
        Ability ability = new Ability();
        ability.AbiltyName = "WATER 1";
        ability.Damage = 10f;
        ability.AbilityCode = AbilityCode.Ability1;
        abilitiesElement.Add(ability);
        abilitiesElement[0].AbilityUse = Ability1;

    }
    void Ability1(List<Character> characters)
    {
        Ability ability = abilitiesElement[0];

        characters[0].DamageCharacter(ability.Damage, this);
        Debug.Log("Player used " + ability.AbiltyName + "!");
    }

    /// <summary>
    /// ABILITY 2 FIRE
    /// Pool of fire. Phoenix Valorant
    /// </summary>

    void InitAbility2()
    {
        Ability ability = new Ability();
        ability.AbiltyName = "FIRE 2";
        ability.Damage = 7f;
        ability.Heal = 5f;
        ability.Duration = 0.5f;
        ability.Times = 4;
        ability.AbilityCode = AbilityCode.Ability2;
        abilitiesElement.Add(ability);
        abilitiesElement[1].AbilityUse = Ability2;
    }
    void Ability2(List<Character> characters)
    {
        Ability ability = abilitiesElement[1];
        foreach (Character item in characters)
        {
            Debug.Log("CHARRS"+  item);

        }
        GameInit.instance.StartCoroutine(Ability2Call(characters, ability.Duration, ability.Times));
        Debug.Log("Player used " + ability.AbiltyName + "!");
    }

    IEnumerator Ability2Call(List<Character> characters, float seconds, int times)
    {
        Ability ability = abilitiesElement[1];
        for (int i = 0; i < times; i++)
        {
            for (int j = 0; j < characters.Count; j++)
            {
                if (characters[j].GetType() == typeof(PlayerController))
                {
                    PlayerModel playerModel = (PlayerModel) ComponentLocator.GetComponent<PlayerModel>();
                    if (playerModel.CurrentElement.ElementName == ElemName.fire)
                    {
                        characters[j].HealCharacter(ability.Heal);
                    } else
                    {
                        characters[j].DamageCharacter(ability.Damage, this);
                    }
                    Debug.Log("Player Health:" + characters[j].Health);
                } else
                {
                    characters[j].DamageCharacter(ability.Damage, this);
                    Debug.Log("Enemy Health:" + characters[j].Health);
                }
            }
            yield return new WaitForSeconds(seconds);
        }
    }

    /// <summary>
    /// ABILITY 3 FIRE
    /// </summary>

    void InitAbility3()
    {
        Ability ability = new Ability();
        ability.AbiltyName = "FIRE 3";
        ability.Damage = 3f;
        ability.Duration = 10f;
        ability.AbilityCode = AbilityCode.Ability3;
        abilitiesElement.Add(ability);
        abilitiesElement[2].AbilityUse = Ability3;
    }
    void Ability3(List<Character> characters)
    {
        Ability ability = abilitiesElement[2];
        characters[0].DamageCharacter(ability.Damage,this);
        GameInit.instance.StartCoroutine(characters[0].SetFireGrade(1, ability.Times));
        Debug.Log("Player used " + ability.AbiltyName + "!");
    }
}
