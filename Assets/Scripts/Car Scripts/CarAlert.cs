using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class CarAlert : MonoBehaviour
{
    public GameObject carAlertBox;
    public GameObject carAlertImagePrefab;
    private Vector3 pos;
    private bool isSpawned = false;

    void TrafficDetect()
    {

        LayerMask mask = (1 << 8);


        var dist = 5.0f;

        RaycastHit hit1;
        Debug.DrawRay(transform.position, -Vector3.forward * dist, Color.green);

        if (Physics.Raycast(transform.position, -Vector3.forward, out hit1, dist, mask))
        {

           //  Debug.Log("Car hit bx alert");
           
            if(!isSpawned)
            {
                StartCoroutine(CarAlertPopUp());
            }

        }
  
    }

    IEnumerator CarAlertPopUp()
    {
        isSpawned = true;
        Instantiate(carAlertImagePrefab, pos, carAlertImagePrefab.transform.rotation);
        yield return new WaitForSeconds(1.0f);
        //delete spawn
        GameObject[] carAlertImageObjects = GameObject.FindGameObjectsWithTag("CarAlertImage");
        for (int i = 0; i < carAlertImageObjects.Length; i++)
        {
            Destroy(carAlertImageObjects[i]);
        }
    }



    void Start()
    {
        pos = carAlertBox.transform.position;
        pos.y += 10; 
        //pos = Vector3(0, 10, 0);
        
    }

    void Update()
    {
        TrafficDetect();
    }

    //position would be the position of the box collider 



    
}

/*
 Collide with car
spawn image
*/