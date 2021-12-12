using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowWater : MonoBehaviour
{
  public float moveDelay = 2f;
  public float moveRate = 2f;
  public bool isVertical = false;
  public bool startMove = false;
  public float maxSpeed = 8f;
  float moveForce;
  public float moveTimer = 0;
  public Rigidbody2D rb2D;
  public Vector2 forceVector;

     public HitByWater healthscript;
    public Transform player;
    public Vector3 respawnbuffer;
    public PlayerRespawn respawnScript;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        moveForce = moveRate * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (healthscript.numHealth <= 0) {
            playerRespawningResetWater();
        }

           moveTimer += 0.01f;
           if (moveTimer >= moveDelay){
                  startMove = true;
                  //GameObject startMove = Instantiate (startDoomEffect, transform.position, transform.rotation);
                  //anim.SetBool("deathmotion", true);
                  //startSFX.Play();
           }

           if (startMove == true){
                  if (isVertical == false){
                         forceVector = new Vector2(moveForce, 0);
                  } else if (isVertical == true) {
                         forceVector = new Vector2(0, moveForce);
                  }

                  //max our movespeed out at 15
                  if(rb2D.velocity.y < maxSpeed) rb2D.velocity += (0.05f)  * forceVector;
           }
    }

    public void playerRespawningResetWater() {
        Debug.Log("Here");
        rb2D.velocity = new Vector2(0f, 0f);
        transform.position = respawnScript.pSpn2 - respawnbuffer;
        moveTimer = 0f;
    }

}
