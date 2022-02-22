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
            carScript.speed = -2;
            StartCoroutine(StopCar());
        }

    }

    IEnumerator StopCar()
    {
        carScript.speed = -7;
        yield return new WaitForSeconds(0.05f);
        carScript.speed = 7;
        yield return new WaitForSeconds(0.2f);
        carScript.speed = 0;
    }
}
