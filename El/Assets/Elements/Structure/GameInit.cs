using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInit : MonoBehaviour
{
    PlayerController player = new PlayerController();
    PlayerModel playerModel = new PlayerModel();
    Enemy enemy = new Enemy();
    // Start is called before the first frame update

    public static GameInit instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        List<Character> enemies = new List<Character>();
        List<Character> all = new List<Character>();

        player.Init();
        enemy.Init();

        enemies.Add(enemy);
        all.Add(enemy);
        all.Add(player);

        //DebugHealth();
        //player.UseAbility(AbilityCode.Ability2, all);
        DebugHealth();
        player.UseAbility(AbilityCode.Ability3, enemies);
        DebugHealth();
        player.UseAbility(AbilityCode.Ability1, enemies);
        DebugHealth();

    }

    // Update is called once per frame
    void Update()
    {
        player.GainAbilityMeter(Time.deltaTime);
        EventDispatcher.eventDispatcher.UpdateAbilityMeter();
        Debug.LogWarning("Ability meter" + playerModel.AbilityMeter);
    }

    void DebugHealth()
    {
        Debug.Log("Player Health:" + player.Health);
        Debug.Log("Enemy Health:" + enemy.Health);
    }

}
