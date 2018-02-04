using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAI : MonoBehaviour {

    public float speed;
    public Transform target;
    public float distance;


    private void Start()
    {
        int unitID = Random.Range(1, 5);
        int unitTypeChoice = Random.Range(0, 2);

        if (unitTypeChoice == 1)
            target = GameObject.Find("GreenMeleeUnit (" + unitID + ")").transform;
        else
            target = GameObject.Find("GreenRangedUnit (" + unitID + ")").transform;
    }

    private void FixedUpdate()
    {
        float z = Mathf.Atan2((target.transform.position.y - transform.position.y), target.transform.position.x - transform.position.x) * Mathf.Rad2Deg - 90;

        transform.eulerAngles = new Vector3(0, 0, z);

        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed);
    }

    private void Update()
    {

    }
}
