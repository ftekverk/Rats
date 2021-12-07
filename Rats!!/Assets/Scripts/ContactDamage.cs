using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class ContactDamage : MonoBehaviour
{
    private GameObject rat;
    private GameObject monster;
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public GameObject[] healthBar;
    public int numHealth;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        rat = GameObject.FindWithTag("Player");
        monster = GameObject.FindWithTag("Monster");
        healthBar  = new GameObject[3];
        healthBar[0] = GameObject.FindWithTag("HealthOne");
        healthBar[1] = GameObject.FindWithTag("HealthTwo");
        healthBar[2] = GameObject.FindWithTag("HealthThree");
        numHealth = 3;
        // healthBar[0].transform.position = new Vector3(-7, 4, -1);
        // healthBar[1].transform.position = new Vector3(-6, 4, -1);
        // healthBar[2].transform.position = new Vector3(-5, 4, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if(numHealth > 0)
        {
            if(objectCollider.IsTouching(anotherCollider))
            {
                int pushback = 0;
                if(rat.transform.position.x > monster.transform.position.x)
                {
                    pushback = 3;
                }
                else
                {
                    pushback = -3;
                }
                rat.transform.position = new Vector3(transform.position.x + pushback, transform.position.y + 1, -1);
                healthBar[numHealth - 1].transform.position = new Vector2(100, 100);
                Thread.Sleep(100);
                numHealth--;
            }
        }
        else
        {
          //  SceneManager.LoadScene(sceneName);
        }

    }
}

// GameObject.FindWithTag("Monster").transform.position = new Vector2(100, 100);
