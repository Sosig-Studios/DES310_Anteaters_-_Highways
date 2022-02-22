using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntEaterCollision : MonoBehaviour
{
    public AnteaterScript patrollerScript;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
            Debug.Log("Anteater Hit Car");
            patrollerScript.speed = 0;
        }

        if (collisionInfo.gameObject.tag == "Anthill")
        {
            Debug.Log("Anteater Hit Anthill");
            patrollerScript.speed = 0;
        }

    }

}
