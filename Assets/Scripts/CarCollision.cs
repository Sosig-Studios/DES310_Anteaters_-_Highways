using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollision : MonoBehaviour
{
    public CarScript carScript;

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "AntEater")
        {
            Debug.Log("Car Hit Anteater");
            StartCoroutine(StopCar());
            changeStateLose();
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

    void changeStateLose()
    {
        SceneManager.LoadScene("LoseState");
        //load lose state if car collides with anteater.
    }
}
