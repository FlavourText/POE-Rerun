using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMeleeAI : MonoBehaviour {

    public float speed;
    public Transform target;
    public float distance;
    Animator anim;


    private void Start()
    {
        //Initialising Annimator
        anim = GetComponent<Animator>();

        //Randoms functions for selecting units to attack
        int unitID = Random.Range(1, 5);
        int unitTypeChoice = Random.Range(0, 2);

        //Units Deciding which Unit to attack
        if (unitTypeChoice == 1)
            target = GameObject.Find("RedMeleeUnit (" + unitID + ")").transform;
        else
            target = GameObject.Find("RedRangedUnit (" + unitID + ")").transform;
    }

    //Method that plays the attack animation 
    private void Animate()
    {
        anim.Play("Attack");
    }

    private void FixedUpdate()
    {
        //Making the Unit face and move towards the current target
        float z = Mathf.Atan2((target.transform.position.y - transform.position.y), target.transform.position.x - transform.position.x) * Mathf.Rad2Deg - 90;

        transform.eulerAngles = new Vector3(0, 0, z);

        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed);
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

        //Conditions for attacking another unit
        if (distance <= 0.8)
        {
            Animate();
        }

        

    }
}
