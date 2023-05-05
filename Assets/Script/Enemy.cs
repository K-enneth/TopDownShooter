using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force;
    public int health = 10;
    

    private void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        StartCoroutine(flash());
        

    }

    IEnumerator flash()
    {
        SpriteRenderer sprite =  GetComponent<SpriteRenderer>();
 
        Color defaultColor = sprite.color;
 
        sprite.color = new Color(1, 1, 1,1);
 
        yield return new WaitForSeconds(0.05f);
 
        sprite.color = defaultColor ;
    }
    
    }
    

    

