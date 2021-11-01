using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    private float abilityMeter = 0f;
    private float abilityMeterMultiplier = 1f;
    private float maxAbilityMeter = 50f;
    private float maxHealth = 100f;
    private Dictionary<ElemName, Element> elements = new Dictionary<ElemName, Element>();
    private Element currentElement;
    

    public float MaxStartingHealth { get { return maxHealth; } }
    public float AbilityMeter { get { return abilityMeter; } set { abilityMeter = value; } }
    public float AbilityMeterMultiplier { get { return abilityMeterMultiplier; } set { abilityMeterMultiplier = value; } }
    public float MaxAbilityMeter { get { return maxAbilityMeter; } set { maxAbilityMeter = value; } }
    public Dictionary<ElemName, Element> Elements { get { return elements; } set { elements = value; } }
    public Element CurrentElement { get { return currentElement; } set { currentElement = value; } }

}
