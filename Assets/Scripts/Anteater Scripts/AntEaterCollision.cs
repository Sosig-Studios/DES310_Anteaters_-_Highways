using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AntEaterCollision : MonoBehaviour
{
    public AnteaterScript patrollerScript;
    public AntEaterCounter antEaterCounterScript;
    public AudioSource audioSource;
   
   
    public AudioClip sfxHit;
    public AudioClip sfxEat;

    [SerializeField]
    float deathDealyTime = 4f;

    public bool HitLeft;

    Animator aeAnim;

    void Start()
    {
        aeAnim = GetComponent<Animator>();
    }

    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Car")
        {
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Car"))
            {
                g.GetComponent<CarScript>().anteaterDead = true;
            }
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("AntEater"))
            {
                g.GetComponent<AnteaterScript>().speed = 0;
            }
            var cl = collisionInfo.gameObject.transform.position;
            if (cl.z > transform.position.z)
                HitLeft = true;

            GameObject.FindGameObjectWithTag("Level Music").GetComponent<AudioSource>().Pause();
            foreach(GameObject a in GameObject.FindGameObjectsWithTag("SFX"))
            {
                a.GetComponent<AudioSource>().Pause();
            }
            
            audioSource.PlayOneShot(sfxHit);
            patrollerScript.speed = 0;
            loseLevel();
            

        }

        if (collisionInfo.gameObject.tag == "Anthill")
        {
            audioSource.PlayOneShot(sfxEat);
            StartCoroutine(eatAnthill(collisionInfo));
            GetComponent<AudioSource>().Play();
            antEaterCounterScript.setCounterDown();
        }


    }

    IEnumerator eatAnthill(UnityEngine.Collision collision)
    {
        aeAnim.SetBool("isEating", true);
        float maxSpeed = patrollerScript.speed;
        patrollerScript.speed = 0;
        yield return new WaitForSeconds(0.2f);
        collision.gameObject.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(0.3f);
        if(collision.gameObject != null)
            Destroy(collision.gameObject);

        do
        {
            patrollerScript.speed += 1;
            aeAnim.SetBool("isEating", false);
            yield return new WaitForSeconds(1.0f);
        }
        while (maxSpeed != patrollerScript.speed);
        
    }

    void loseLevel()
    {

        StartCoroutine("DeathSequence");
        
        if(HitLeft)
        {
            aeAnim.SetBool("isDeadLeft", true);
        }
        else
        {
            aeAnim.SetBool("isDeadRight", true);
        }
    }

    IEnumerator DeathSequence()
    {
        GetComponent<deathCollect>().isDead = true;
        yield return new WaitForSeconds(deathDealyTime);
        SceneManager.LoadScene("LoseState"); //load win state 
    }


}
