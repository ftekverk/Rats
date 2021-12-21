using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatCombatNoEnemies : MonoBehaviour
{

    public Animator animator;

    public AudioClip sword;
    AudioSource audio;
    public float attackRange = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
      audio = GetComponent<AudioSource>(); 
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
      audio.clip = sword;
      audio.Play();
        //Play attack animation
        animator.SetTrigger("Attack");
    }
}
