using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class HitDrop : MonoBehaviour
{
    //private GameObject rat;
    //private GameObject spike;
    //public Collider2D objectCollider;
    //public Collider2D anotherCollider;
    //public PlayerHealth playerhealth;
    //public bool canDamage = true;


    // Start is called before the first frame update
    void Start()
    {
        //rat = GameObject.FindWithTag("Player");
        //drop = GameObject.FindWithTag("WaterDrop");
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

    //IEnumerator DamageDelay()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //   canDamage = true;
    //}
}