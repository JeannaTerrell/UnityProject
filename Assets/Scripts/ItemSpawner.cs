using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItemSpawner : MonoBehaviour
{
    public GameObject Mushroom;
    public GameObject Coin;
    public float SpawnTime = 1f;
    public float y = 9;
    public int SpawnAmtMin;
    public int SpawnAmtMax;

    private float _MushroomCount = 1;
    Vector3 pos;

    private void Start()
    {
        StartCoroutine(makeItems());
    }


    private IEnumerator makeItems()
    {
        float x, z;
        int RandomSpawnAmt = Random.Range(SpawnAmtMin, SpawnAmtMax);
        while (true)
        {
            var rotation = Quaternion.identity;
            x = Random.Range(-10, 10);
            z = 0;
            pos = new Vector3(x, y, z);
            transform.position = pos;


            if (_MushroomCount % RandomSpawnAmt == 0)
            {
                Instantiate(Coin, transform.position, rotation);
                _MushroomCount = 1;
                RandomSpawnAmt = Random.Range(SpawnAmtMin, SpawnAmtMax);
            }
            else
            {
                Instantiate(Mushroom, transform.position, rotation);
                _MushroomCount++;
            }

            yield return new WaitForSeconds(SpawnTime);
            
        }
    }

}
