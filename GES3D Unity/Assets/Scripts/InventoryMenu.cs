using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject inventoryMenuPanel;

    private bool IsMenuShowing
    {
        get { return inventoryMenuPanel.activeSelf; }
    
    }

    // Use this for initialization
	

    void Start ()
    {
        HideMenu();
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        HandleInput();
		
	}

    private void  HideMenu()
    {
        inventoryMenuPanel.SetActive(false);
    }

    private void ShowMenu()
    {
        inventoryMenuPanel.SetActive(true);
    }

    private void HandleInput()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (IsMenuShowing)
                HideMenu();
            else
                ShowMenu();
        }
    }


}
