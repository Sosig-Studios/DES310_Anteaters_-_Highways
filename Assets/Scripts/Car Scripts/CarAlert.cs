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
    public float despawnTime = 1;
    private bool isSpawned = false;

    void CollisionDetect()
    {

        LayerMask mask = (1 << 8);
        var dist = 5.0f;

        RaycastHit hit1;
        Debug.DrawRay(transform.position, Vector3.forward * dist, Color.green); ;

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
        popUp.SetActive(true);
        yield return new WaitForSeconds(despawnTime);
        popUp.SetActive(false);

        isSpawned = false; // reset for next car
    }



    void Start()
    {
        popUp.SetActive(false);
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