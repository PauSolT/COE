using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element 
{
    private ElemName elementName;
    protected List<Ability> abilitiesElement = new List<Ability>();

    public ElemName ElementName { get { return elementName; } set { elementName = value; } }

    public void AbilityUse(AbilityCode abilityCode, List<Character> characters)
    {
        GetAbilityByElement(abilityCode).AbilityUse(characters);
    }

    public Ability GetAbilityByElement(AbilityCode abilityCode)
    {
        foreach (Ability ability in abilitiesElement)
        {
            if (ability.AbilityCode == abilityCode) { return ability; }
        }
        return null;
    }

    public virtual void Init() {  }

}

public enum ElemName
{
    fire,
    water,
    earth,
    air
}
