using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Rat_Combat : MonoBehaviour
{
   public Animator animator;
   
   public AudioClip sword;
   public AudioClip monster;
   AudioSource audio;

   public Transform attackPoint;
   public float attackRange = 0.5f;
   public LayerMask enemyLayers;
   
   void Start() {
     
     audio = GetComponent<AudioSource>(); 
     
   }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("z")) {
            Attack();
        }
    }

    void Attack() {
      
        audio.clip = sword;
        audio.Play();
        //Play attack animation
        animator.SetTrigger("Attack");

        //Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //Damage them

        foreach(Collider2D enemy in hitEnemies) {
           audio.clip = monster;
           audio.Play();
           enemy.GetComponent<Enemy>().TakeDamage(5);
           Thread.Sleep(100);
        }
    }

    void OnDrawGizmosSelected() {
    if (attackPoint == null)
        return;
        
    Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

