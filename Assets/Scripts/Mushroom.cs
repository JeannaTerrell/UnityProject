using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    private void Update()
    {
        var myPos = transform.position;
        if (myPos.y < -4.5)
        {
            Destroy(this.gameObject);
        }
    }

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
