using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public CarScript carScript;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "AntEater")
        {
            Debug.Log("Hit");
            carScript.speed = 0;
        }

    }
}
