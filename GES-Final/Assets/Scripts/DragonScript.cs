using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonScript : MonoBehaviour, IActivatable
{
    public List<string> items;

    public string NameText { get { return "Find my three Gems"; }}

    public void DoActivate()
    {
        if (items.Contains("Forest Gem") && items.Contains("Mountain Gem") && items.Contains(("Blue Gem")))
        {
            print("fuck aaron");
            SceneManager.LoadScene("Win");
        }
    }
}
