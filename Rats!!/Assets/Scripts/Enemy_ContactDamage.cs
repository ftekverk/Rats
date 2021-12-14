using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class Enemy_ContactDamage : MonoBehaviour
{
    private GameObject rat;
    private GameObject monster;
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public PlayerHealth playerhealth;
    public bool canDamage = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rat = GameObject.FindWithTag("Player");
        monster = GameObject.FindWithTag("Monster");
    }

    // Update is called once per frame
    void Update()
    {
        if(objectCollider.IsTouching(anotherCollider))
        {
            if(playerhealth.numHealth > 0)
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

                if(canDamage)
                {
                    playerhealth.numHealth--;
                    canDamage = false;
                    StartCoroutine(DamageDelay());
                }
            }
            

        }
        
    }

    IEnumerator DamageDelay()
    {
        yield return new WaitForSeconds(0.5f);
        canDamage = true;
    }

}