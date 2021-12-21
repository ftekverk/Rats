using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class HitByWater : MonoBehaviour
{
    public Collider2D waterCollider;
    public Rigidbody2D waterRb;
    public Rigidbody2D rb;
    public Collider2D ratBody;
    public int knockupSpeed = 5;
    // Start is called before the first frame update
    public PlayerHealth healthscript;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ratBody.IsTouching(waterCollider))
        {
            healthscript.numHealth = healthscript.numHealth - 1;
            rb.velocity = new Vector2(rb.velocity.x, waterRb.velocity.y + knockupSpeed);
            Thread.Sleep(100);
        }
    }
}
