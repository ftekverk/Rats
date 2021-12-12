
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public Transform pSpawn;       // current player spawn point
    public HitByWater healthscript;
    bool reset_level = true;
    public Vector3 pSpn2;

    void Start()
    {
       
    }

    void Update()
    {
        if (healthscript.numHealth <= 0)
        {
            healthscript.numHealth = 3;
            //comment out lines from GameHandler about EndLose screen
            Debug.Log("I am going back to the last spawn point");
            if (reset_level)
            {
                SceneManager.LoadScene("FlowingWater");
            }
            if (pSpawn != null)
            {
                 pSpn2 = new Vector3(pSpawn.position.x, pSpawn.position.y, transform.position.z);
                gameObject.transform.position = pSpn2;
            }
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            pSpawn = other.gameObject.transform;
            GameObject thisCheckpoint = other.gameObject;
            reset_level = false;
            //StopCoroutine(changeColor(other));
           // StartCoroutine(changeColor(other));
        }
    }
}