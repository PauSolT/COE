using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventDispatcher : MonoBehaviour
{

    public static EventDispatcher eventDispatcher;

    public event Action updateAbilityMeter;
    // Start is called before the first frame update
    void Awake()
    {
        eventDispatcher = this;
    }

    public void UpdateAbilityMeter()
    {
        if (updateAbilityMeter != null)
        {
            updateAbilityMeter();
        }
    }

    // Update is called once per fra
}
