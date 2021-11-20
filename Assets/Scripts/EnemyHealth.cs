using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private Rigidbody2D entity;
    public bool canTakeDamage;
    public GameObject enemyPrefab;

    public int health = 3;
    public int numOfHearts = 3;

    // Start is called before the first frame update
    void Start()
    {
        entity = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        if (health == 0)
            Destroy(gameObject);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (canTakeDamage)
        {
            if (col.gameObject.tag == "Damage")
                health--;
        }
    }
}
