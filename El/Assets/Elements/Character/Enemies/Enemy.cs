using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

    private const float maxStartingHealth = 200f;

    public override void Init()
    {
        MaxHealth = maxStartingHealth;
        Health = MaxHealth;
    }
}
