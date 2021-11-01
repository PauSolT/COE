using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    public Slider abilityMeter;

    //PlayerModel player = null;
   
    public void Awake()
    {
        //abilityMeter = GameObject.Find("Canvas/AbilityMeterG").GetComponent<Slider>();
        PlayerModel pm = (PlayerModel) ComponentLocator.GetComponent<PlayerModel>();
        abilityMeter.maxValue = pm.MaxAbilityMeter;
    }

    public void Init()
    {

    }

    public void UpdateAbilityMeterSlider()
    {
        //abilityMeter.value = playerModel.AbilityMeter;
    }
}
