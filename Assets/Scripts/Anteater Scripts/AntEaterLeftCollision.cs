using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntEaterLeftCollision : MonoBehaviour
{
    public AntEaterCollision AntEaterCollisionScript;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
            AntEaterCollisionScript.HitLeft = true;
            Debug.Log("Car Hit Left Side of Anteater");
        }
    }
}
