using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathCollect : MonoBehaviour
{
    public GameObject gameManager;
    public bool isDead = false;

    public Material deadMaterial;

    public GameObject anteater;
    // Update is called once per frame
    void Update()
    {
        if(isDead == true)
        {
            gameManager.GetComponent<deathCamera>().killedAnteater = gameObject;
            gameManager.GetComponent<deathCamera>().DeathScreen();
            anteater.GetComponent<SkinnedMeshRenderer>().material = deadMaterial;
            foreach(Light l in FindObjectsOfType<Light>())
            {
                l.enabled = false;
            }
        }
    }
}
