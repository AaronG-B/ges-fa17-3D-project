using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObbject : MonoBehaviour {

	// Use this for initialization
	private void Start () 
    {
        Deactivate();
		
	}
	
    private void Deactivate()
    {

        Debug.Log(transform.name + " was activated!");


    }
	// Update is called once per frame
	void Update () {
		
	}
}
