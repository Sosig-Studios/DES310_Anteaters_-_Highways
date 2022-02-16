using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{


    public Patroller carPatroller;//accessor for patroller script to get speed variable

    public float carStartTimer = 3.0f; //public variable for car start up timer initially set to 3

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && this.gameObject.tag == "Car")// set to 0 as 0 is the left mouse button 
        {

            RaycastHit rayHit;

            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(mouseRay, out rayHit, 100.0f))
            {
                if (rayHit.transform != null)
                {
                    carPatroller.speed = 0; //set car speed to 0 if hit by raycast
                }


            }
        }
        else
        {
            carStart();//start up car after its stopped
        }
    }

    void carStart()
    {
        carStartTimer -= Time.deltaTime; //take frame time away from the car start timer

        if (carStartTimer <= 0.0f) //check if timer is less than or eqau to zero
        {
 
           carPatroller.speed = 10;
            
        }
    }

 
}
