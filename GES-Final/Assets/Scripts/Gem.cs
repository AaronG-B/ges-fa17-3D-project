using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, IActivatable
{
    public string NameText { get { return ""; }}

    public void DoActivate()
    {
        FindObjectOfType<DragonScript>().items.Add(gameObject.name);
    }
}
