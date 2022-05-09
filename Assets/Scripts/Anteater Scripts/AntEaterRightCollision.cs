using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntEaterRightCollision : MonoBehaviour
{
    public AntEaterCollision AntEaterCollisionScript;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
            AntEaterCollisionScript.HitLeft = false;
            Debug.Log("Car Hit Right Side of Anteater");
        }
    }
}
