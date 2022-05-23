using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Update()
    {
        var myPos = transform.position;
        if(myPos.y < -10)
        
        {
            if (gameObject == null)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public int coinValue = 1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var pointSys = col.gameObject.GetComponent<PointSystem>();
            pointSys.AddPoints(coinValue);
            Destroy(this.gameObject);
        }
    }
}
