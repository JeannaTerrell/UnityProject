using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    private int _points;


    private void Start()
    {
        _points = 0;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void AddPoints(int coinValue)
    {
        _points += coinValue;
        Debug.Log("Points: " + _points);
    }
}
