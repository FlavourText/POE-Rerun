using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAI : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Transform target;
        int unitID = Random.Range(1, 5);
        int unitTypeChoice = Random.Range(0, 2);
        
        if (unitTypeChoice == 1)
            target = GameObject.Find("GreenMeleeUnit (" + unitID + ")").transform;
        else
            target = GameObject.Find("GreenRangedUnit (" + unitID + ")").transform;























    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {
        
    }
}
