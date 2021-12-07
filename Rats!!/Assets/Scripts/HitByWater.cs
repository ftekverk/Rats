using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class HitByWater : MonoBehaviour
{
    public Collider2D waterCollider;
    public Rigidbody2D waterRb;
    public Rigidbody2D rb;
    public Collider2D ratBody;
    public GameObject[] healthBar;
    public int numHealth;
    public string sceneName;
    public int knockupSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
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
            if(ratBody.IsTouching(waterCollider))
            {
                rb.velocity = new Vector2(rb.velocity.x, waterRb.velocity.y + knockupSpeed);

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
