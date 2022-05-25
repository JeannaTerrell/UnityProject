using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenAppleSpawner : MonoBehaviour
{
    public GameObject GoldenApple;
    public Vector3 appleSpawn1 = new Vector3(-15, 1, 0);
    public Vector3 appleSpawn2 = new Vector3(15, 1, 0);
    int platformNum = 2;

    private GameObject _newApple;

    private void Start()
    {
        var rotation = Quaternion.identity;
        _newApple = Instantiate(GoldenApple, appleSpawn2, rotation);
    }

    private void Update()
    {
        var rotation = Quaternion.identity;

        if (_newApple == null && platformNum == 1)
        {
            _newApple = Instantiate(GoldenApple, appleSpawn2, rotation);
            platformNum = 2;
        }
        else if (_newApple == null && platformNum == 2)
        {
            _newApple = Instantiate(GoldenApple, appleSpawn1, rotation);
            platformNum = 1;
        }
    }
}

