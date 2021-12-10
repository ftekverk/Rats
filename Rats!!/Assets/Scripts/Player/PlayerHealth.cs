using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameObject[] healthBar;
    public int numHealth;
    public string sceneName;
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
        if(numHealth > 0 && numHealth < 3)
        {
            healthBar[numHealth].SetActive(false);
            //healthBar[numHealth].transform.position = new Vector2(100, 100);
          //  StartCoroutine(MyDelay());
            //Thread.Sleep(100);
        }
        else if (numHealth < 1)
        {
            //send to checkpoint
            SceneManager.LoadScene(sceneName);
        }

    }


}
