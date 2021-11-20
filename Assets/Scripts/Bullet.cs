using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //This would be the explosion animation:
    //public GameObject hitEffect;


    void OnCollisionEnter2D(Collision2D col)
    {
        //To instantiate the explosion animation:
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Quaternion.identity is a fancy way of saying neglect rotation
        //Destroy(effect, 0.5f);
        //5f is 5 seconds delay
        Destroy(gameObject);
    }
}
