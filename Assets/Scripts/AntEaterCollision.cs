using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntEaterCollision : MonoBehaviour
{
    public AnteaterScript patrollerScript;
    public AudioSource SfxChime;
    public AudioSource SfxEat;


    void Start()
    {
        SfxChime = GetComponent<AudioSource>();
        SfxEat = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
            Debug.Log("Anteater Hit Car");
            patrollerScript.speed = 0;
            loseLevel();
        }

        if (collisionInfo.gameObject.tag == "Anthill")
        {
            Debug.Log("Anteater Hit Anthill");
            StartCoroutine(eatAnthill(collisionInfo));
            SfxChime.Play();
        }


    }

    IEnumerator eatAnthill(UnityEngine.Collision collision)
    {
        SfxEat.Play();
        float maxSpeed = patrollerScript.speed;
        patrollerScript.speed = 0;
        yield return new WaitForSeconds(0.5f);
        Destroy(collision.gameObject);

        do
        {
            patrollerScript.speed += 1;
            yield return new WaitForSeconds(1.0f);
        }
        while (maxSpeed != patrollerScript.speed);
        
    }

    void loseLevel()
    {
        SceneManager.LoadScene("LoseState"); //load win state 
    }
}
