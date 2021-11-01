using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability 
{

    private string abilityName;
    private float damage;
    private float heal;
    private float range;
    private float duration;
    private float cooldown;
    private float castTime;
    private int times;
    private int elementGrade;
    private AbilityCode abilityCode;


    public float Damage { get { return damage; } set { damage = value; } }
    public float Heal { get { return heal; } set { heal = value; } }
    public float Range { get { return range; } set { range = value; } }
    public float Duration { get { return duration; } set { duration = value; } }
    public float Cooldown { get { return cooldown; } set { cooldown = value; } }
    public float CastTime { get { return castTime; } set { castTime = value; } }
    public int Times { get { return times; } set { times = value; } }
    public int ElementGrade { get { return elementGrade; } set { elementGrade = value; } }
    public string AbiltyName { get { return abilityName; } set { abilityName = value; } }
    public AbilityCode AbilityCode { get { return abilityCode; } set { abilityCode = value; } }

    public virtual void Init() { }

    public System.Action<List<Character>> AbilityUse;

}

public enum AbilityCode
{
    Ability1,
    Ability2,
    Ability3,
    Ability4
}