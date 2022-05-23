using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    //public GameObject Shroom;

    public int Damage = 5;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var healthSys = col.gameObject.GetComponent<HealthSystem>();
            healthSys.TakeDamage(Damage);
        }
    }

    
}
