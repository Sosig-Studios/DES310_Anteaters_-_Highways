using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnthillCollision : MonoBehaviour
{

    public Patroller patrollerScript;

    void OnCollisionEnter(UnityEngine.Collision col)
    {

        if (col.gameObject.tag == "Anthill")
        {

            print("Anteater Hit Anthill");
            StartCoroutine(eatAnthill(col));

        }
    }
    IEnumerator eatAnthill(UnityEngine.Collision collision)
    {
        float maxSpeed = patrollerScript.speed;
        patrollerScript.speed = 0;
        yield return new WaitForSeconds(0.1f);
        Destroy(collision.gameObject);

        while(maxSpeed != patrollerScript.speed)
        {
            patrollerScript.speed += 2;
            yield return new WaitForSeconds(1.0f);
        }
    }

}
