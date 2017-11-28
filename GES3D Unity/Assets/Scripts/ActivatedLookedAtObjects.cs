using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatedLookedAtObjects : MonoBehaviour {
    [SerializeField]
    private float maxActiveDistance = 4.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.DrawRay(transform.position, Vector3.forward * maxActiveDistance, Color.blue);
        RaycastHit raycastHit;

        Physics.Raycast(transform.position, transform.forward, out raycastHit);

        Iactivatable objectLookedAt = raycastHit.transform.GetComponent<Iactivatable>();


	}
}
