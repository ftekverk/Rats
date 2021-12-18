using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWebs : MonoBehaviour
{

    public LayerMask webLayer;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("z")) {
          DestroyWebsInFront();
      }
    }



    public void DestroyWebsInFront(){

      //Detect webs in range of attack
      Collider2D[] websToDestroy = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, webLayer);
      foreach(Collider2D webs in websToDestroy) {
         webs.GetComponent<SpriteRenderer>().enabled = false;
         webs.GetComponent<Collider2D>().enabled = false;
      }

    }
}
