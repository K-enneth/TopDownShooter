using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int damage;
    private Transform posicion;
    public float pushback;
    private void Update()
    {
        
        StartCoroutine(BalaGone());
    }

    IEnumerator BalaGone()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
        
        if (collision.transform.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().takeDamage(damage);
            
            Rigidbody2D enemy = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 difference = (enemy.transform.position - transform.position).normalized * pushback;
            enemy.AddForce(difference,ForceMode2D.Impulse);
            enemy.velocity = Vector2.zero;

            
        }
    }

  

}
