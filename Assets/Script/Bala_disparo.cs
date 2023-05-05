using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala_disparo : MonoBehaviour
{
    public GameObject bala1;
    public float balaSpeed;
    public Transform disparo;
    public float shootDelay = 10f;
    private float timeShoot = 10f;
    public bool moreBullets;
    public GameObject player;

   


    void Update()
    {
        timeShoot += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && timeShoot >= shootDelay)
        {
            Rigidbody2D play = player.GetComponent<Rigidbody2D>();
            Vector2 difference = transform.position - player.transform.position.normalized * balaSpeed;
            
            play.AddForce(difference,ForceMode2D.Impulse);
            
            GameObject bala = Instantiate(bala1, disparo.position, disparo.rotation);
            bala.GetComponent<Rigidbody2D>().AddForce(disparo.up * balaSpeed, ForceMode2D.Impulse);
            
            
            if (moreBullets == true)
            {
                GameObject Obala = Instantiate(bala1, disparo.position + new Vector3(0,1,0), disparo.rotation);
                Obala.GetComponent<Rigidbody2D>().AddForce(disparo.up * balaSpeed, ForceMode2D.Impulse);
                
                GameObject Ibala = Instantiate(bala1, disparo.position + new Vector3(0,2,0), disparo.rotation);
                Ibala.GetComponent<Rigidbody2D>().AddForce(disparo.up * balaSpeed, ForceMode2D.Impulse);
            }
          
            timeShoot = 0;
        }


    }
    
}
