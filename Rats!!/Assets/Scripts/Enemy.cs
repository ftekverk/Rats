using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy: MonoBehaviour
{
    int moveSpeed;
    int attackDamage;
    int lifePoints;
    int currentHP;
    float attackRadius;

    //movement
    float followRadius;

    public GameObject monster;
    public GameObject rat;

    public void setMoveSpeed(int speed)
    {
        moveSpeed = speed;
    }

    public void setAttackDamage(int attdmg)
    {
        attackDamage = attdmg;
    }

    public void setLifePoints(int lp)
    {
        lifePoints = lp;
    }

    public int getMoveSpeed()
    {
        return moveSpeed;
    }

    public int getAttackDamage()
    {
        return attackDamage;
    }

    public int getLifePoints()
    {
        return lifePoints;
    }


    //movement toward a player
    public void setFollowRadius(float r)
    {
        followRadius = r;
    }
    //attack radius
    public void setAttackRadius(float r)
    {
        attackRadius = r;
    }

    //if player in radius move toward him
    public bool checkFollowRadius(float playerPosition, float enemyPosition)
    {
        if(Mathf.Abs(playerPosition -enemyPosition) < followRadius)
        {
            //player in range
            return true;
        }
        else
        {
            return false;
        }
    }

    //if player in radius attack him
    public bool checkAttackRadius(float playerPosition, float enemyPosition)
    {
        if (Mathf.Abs(playerPosition - enemyPosition) < attackRadius)
        {
            //in range for attack
            return true;
        }
        else
        {
            return false;
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("lifepoints: " + getLifePoints());
        
        lifePoints -= damage;
        
        Debug.Log("lifepoints: " + getLifePoints());
        
        if (lifePoints <= 0) {
            Die();
        }
        else
        {
            int pushback = 0;
            if(rat.transform.position.x < monster.transform.position.x)
            {
                pushback = 3;
            }
            else
            {
                pushback = -3;
            }
            monster.transform.position = new Vector3(monster.transform.position.x + pushback, monster.transform.position.y, -0);
        }
    }

    void Die() {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
