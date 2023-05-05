using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class changeW : MonoBehaviour
{
  public GameObject[] armas;

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
      ChangeWeapon(0);
    }
    
    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      ChangeWeapon(1);
    }
    
    if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      ChangeWeapon(2);
    }
    
  }

  private void ChangeWeapon(int arma)
  {
    for (int i = 0; i < armas.Length; i++)
    {
      if (i == arma)
      {
        armas[i].gameObject.SetActive(true);
      }
      else
      {
        armas[i].gameObject.SetActive(false);
      }
    }
  }
}
