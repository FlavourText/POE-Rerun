using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAI : MonoBehaviour {

    public float speed;
    public Transform target;
    public float distance;
    Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();

        //int unitID = Random.Range(1, 3);
        //target = GameObject.Find("RedMeleeUnit (" + unitID + ")").transform;
    }

    private void Animate()
    {
        anim.Play("Attack");
    }

    private void FixedUpdate()
    {
        float z = Mathf.Atan2((target.transform.position.y - transform.position.y), target.transform.position.x - transform.position.x) * Mathf.Rad2Deg - 90;

        transform.eulerAngles = new Vector3(0, 0, z);

        GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up * speed);
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

        if (distance <= 2.5)
        {
            Animate();
        }



    }
}
