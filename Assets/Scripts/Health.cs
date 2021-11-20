using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    private Rigidbody2D entity;
    public bool canTakeDamage;
    public GameObject enemyPrefab;

    public int health = 3;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

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

        for(int i=0;i<hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (canTakeDamage)
        {
            if (col.gameObject.tag == "Enemy")
                health--;
            //if (col.gameObject == enemyPrefab)
                //health--;
        }
    }

}
