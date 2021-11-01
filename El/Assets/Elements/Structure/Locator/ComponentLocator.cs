using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ComponentLocator
{
    private static List<IComponent> components = new List<IComponent>();

    public static void AddComponent(IComponent component)
    {
        components.Add(component);
    }

    public static IComponent GetComponent<T>()
    {
        foreach (IComponent component in components)
        {
            if (component.GetType() == typeof(T))
            {
                return component;
            }
        }
        return null;
    }
}

public interface IComponent
{

}