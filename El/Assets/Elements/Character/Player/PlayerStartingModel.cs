using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartingModel
{
    private const float startingMaxHealth = 100f;

    private Dictionary<ElemName, Element> startingElements = new Dictionary<ElemName, Element>();

    private Element startingCurrentElement = new Fire();

    public float StartingMaxHealth { get { return startingMaxHealth; } }
    public Dictionary<ElemName, Element> StartingElements { get { return startingElements; } }
    public Element StartingCurrentElement { get { return startingCurrentElement; } }
}