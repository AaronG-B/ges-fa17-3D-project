using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void CreditButtonClicked()
    {
        SceneManager.LoadScene("Credits");
    }


    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
