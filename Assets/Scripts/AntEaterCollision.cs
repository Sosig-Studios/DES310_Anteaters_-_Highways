using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            StartCoroutine(eatAnthill(collisionInfo));

        }

        if (collisionInfo.gameObject.tag == "Tree")
        {
            Debug.Log("Anteater Hit Tree");
            endLevel();// ends level...
        }

    }

    IEnumerator eatAnthill(UnityEngine.Collision collision)
    {
        float maxSpeed = patrollerScript.speed;
        patrollerScript.speed = 0;
        yield return new WaitForSeconds(0.1f);
        Destroy(collision.gameObject);

        while (maxSpeed != patrollerScript.speed)
        {
            patrollerScript.speed += 2;
            yield return new WaitForSeconds(1.0f);
        }
    }

    void endLevel()
    {
        SceneManager.LoadScene("WinState"); //load win state 
    }

}
