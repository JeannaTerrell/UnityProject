using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenApple : MonoBehaviour
{
    public int pointValue = 10;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var pointSys = col.gameObject.GetComponent<PointSystem>();
            pointSys.AddPoints(pointValue);
            Destroy(this.gameObject);
        }
    }
}
