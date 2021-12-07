using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatCombatNoEnemies : MonoBehaviour
{

    public Animator animator;

    public float attackRange = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Play attack animation
        animator.SetTrigger("Attack");
    }
}
