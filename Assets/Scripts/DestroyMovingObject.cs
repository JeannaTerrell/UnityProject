using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMovingObject : MovingObject
{
    protected override void OnReachedTarget()
    {
        Destroy(gameObject);
    }
}
