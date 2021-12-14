using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class HitSpikes : MonoBehaviour
{
    private GameObject rat;
    private GameObject spike;
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public PlayerHealth playerhealth;
    public bool canDamage = true;

    
    // Start is called before the first frame update
    void Start()
    {
        rat = GameObject.FindWithTag("Player");
        spike = GameObject.FindWithTag("Spike");
    }

    // Update is called once per frame
    void Update()
    {
        if(objectCollider.IsTouching(anotherCollider))
        {
            int pushback = 0;
            if(rat.transform.position.x > spike.transform.position.x)
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
    IEnumerator DamageDelay()
    {
        yield return new WaitForSeconds(0.5f);
        canDamage = true;
    }
}