using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ContactDamage : MonoBehaviour
{
    private GameObject rat;
    private GameObject monster;
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public GameObject[] healthBar;
    public int numHealth;
    // Start is called before the first frame update
    void Start()
    {
        rat = GameObject.Find("Rat!");
        monster = GameObject.Find("monster");
        healthBar  = new GameObject[3];
        healthBar[0] = GameObject.FindWithTag("HealthOne");
        healthBar[1] = GameObject.FindWithTag("HealthTwo");
        healthBar[2] = GameObject.FindWithTag("HealthThree");
        numHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(numHealth > 0)
        {
            if(objectCollider.IsTouching(anotherCollider))
            {
                rat.transform.position = new Vector3(transform.position.x - 3, transform.position.y, -1);
                healthBar[numHealth - 1].transform.position = new Vector2(100, 100);
                Thread.Sleep(100);
                numHealth--;
            }
        }

    }
}

// GameObject.FindWithTag("Monster").transform.position = new Vector2(100, 100);