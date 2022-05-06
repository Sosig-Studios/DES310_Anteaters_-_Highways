using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class CarAlert : MonoBehaviour
{
    public GameObject carAlertBox;

    //canvas instatiate
    public GameObject HUD;
    public GameObject popUp;


    public Vector3 imagePosition;
    public Vector3 imageScale;
    public float despawnTime;
    private bool isSpawned = false;

    void CollisionDetect()
    {

        LayerMask mask = (1 << 8);
        var dist = 5.0f;

        RaycastHit hit1;

        if (Physics.Raycast(transform.position, -Vector3.forward, out hit1, dist, mask))
        {

           
            if(!isSpawned)
            {
                StartCoroutine(CarAlertPopUp());
            }

        }
  
    }

    IEnumerator CarAlertPopUp()
    {
        isSpawned = true;
        var createImage = Instantiate(popUp) as GameObject;
        createImage.transform.SetParent(HUD.transform, false);
        createImage.transform.position += imagePosition;
        createImage.transform.localScale += imageScale;
        //
        yield return new WaitForSeconds(despawnTime);
        //delete spawn
        GameObject[] carAlertImageObjects = GameObject.FindGameObjectsWithTag("CarAlertImage");
        for (int i = 0; i < carAlertImageObjects.Length; i++)
        {
            Destroy(carAlertImageObjects[i]);
        }

        isSpawned = false; // reset for next car
    }



    void Start()
    {
    }

    void Update()
    {
        CollisionDetect();
    }


    
}

/*
add scaling
and wait time
*/