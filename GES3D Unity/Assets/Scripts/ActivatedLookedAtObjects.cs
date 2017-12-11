using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivatedLookedAtObjects : MonoBehaviour {
    [SerializeField]
    private float maxActiveDistance = 4.0f;

    private Iactivatable objectLookedAt;

    [SerializeField]
    Text objectLookedAtText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.DrawRay(transform.position, Vector3.forward * maxActiveDistance, Color.blue);
        RaycastHit raycastHit;

        //Physics.Raycast(transform.position, transform.forward, out raycastHit);

        //Iactivatable objectLookedAt = raycastHit.transform.GetComponent<Iactivatable>();

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxActiveDistance))
        {
            Debug.Log("Raycast hit" + raycastHit.transform.name);

            objectLookedAt = raycastHit.transform.GetComponent<Iactivatable>();


        }

	}

    private void UpdateLookedAtObjectText()
    {
        if (objectLookedAt == null)
        {
            objectLookedAtText.text = string.Empty;
        }
        else
        {
            objectLookedAtText.text = objectLookedAt.NameText;


        }
    }
}
