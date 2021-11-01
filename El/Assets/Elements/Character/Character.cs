using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    private float maxHealth;
    private float health;

    int fireGrade = 0;


    public float Health { get { return health; } set { health = value; } }
    public float MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
    public int FireGrade { get { return fireGrade; } set { fireGrade = value; } }

    public virtual void Init() { }

    public virtual IEnumerator SetFireGrade(int fireG, float seconds)
    {
        FireGrade = fireG;
        Debug.Log("CHARACTER ON FIERE");
        yield return new WaitForSeconds(seconds);
        FireGrade = 0;
    }

    public void DamageCharacter(float damage, Element elem)
    {
        if (FireGrade > 0)
        {
            damage *= 1.5f;
        }

        Health -= damage;

        if (Health <= 0)
        {
            Debug.Log("Characte died!");
        }
    }

    public void HealCharacter(float heal)
    {
        if (Health + heal > MaxHealth)
        {
            Health = MaxHealth;
        } else
        {
            Health += heal;
        }
    }
}