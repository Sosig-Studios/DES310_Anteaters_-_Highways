using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public SpeedButtons speedButtonsScript;
    public Transform[] waypoints;
    public int setSpeed;
    private int newSpeed;

    private int waypointIndex;
    private float distance;
    private float maxSpeed;

    bool inTraffic = false;
    private bool carAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        carAlive = true;
        newSpeed = setSpeed;
        //Debug.Log(speedButtonsScript.speedModifier);
        //Debug.Log(setSpeed);

        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        maxSpeed = newSpeed * speedButtonsScript.speedModifier;
        DeleteCar();
        if(carAlive)
        {
            TrafficDetect();
            distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
            if (distance < 1f)
            {
                IncreaseIndex();
            }
            if (!inTraffic)
            {
                Patrol();
            }
        }
    
        
            
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * setSpeed * speedButtonsScript.speedModifier * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex < waypoints.Length)
        {
            //waypointIndex = 0;
            transform.LookAt(waypoints[waypointIndex].position);
        }
        
    }

    void DeleteCar()
    {
        if(waypointIndex >= waypoints.Length)
        {
            //Debug.Log("Destroy Car Hit");
            Object.Destroy(this.gameObject);
            carAlive = false;
        }
    }


    void OnMouseDown()
    {
        StartCoroutine(SlowDownCar());
        //potential fix: - if this takes less than a second start speed up car
    }

    void OnMouseUp()
    {
        //Debug.Log("Mouse Up");

        StartCoroutine(SpeedUpCar());
    }

    IEnumerator SlowDownCar()
    {
        while (setSpeed != 0)
        {
            setSpeed -= 1;
            yield return new WaitForSeconds(0.1f);
            //Debug.Log("set speed: " + setSpeed);
        }

    }

    IEnumerator SpeedUpCar()
    {
        while (setSpeed != newSpeed)
        {
            yield return new WaitForSeconds(0.05f);
            setSpeed += 1;
            //Debug.Log("set speed: " + setSpeed);
        }

        /*
         i dont know how to get on hold working
        i think when you click on unity it doesnt always recognise the mouse as up, thats the only explanation i can think of
         */
    }
    void TrafficDetect()
    {

        LayerMask mask = (1 << 8);


        var dist = 5.0f;
        var sdist = 3.0f;

        RaycastHit hit1;
        //RaycastHit hit2; //error hit 2 and 3 never used
        //RaycastHit hit3;
        var forward = transform.TransformDirection(Vector3.forward);
        var left = transform.TransformDirection(Vector3.left);
        var right = transform.TransformDirection(Vector3.right);
        Debug.DrawRay(transform.position, forward * dist, Color.green);
        Debug.DrawRay(transform.position, left * sdist, Color.green);
        Debug.DrawRay(transform.position, right * sdist, Color.green);


        if (Physics.Raycast(transform.position, forward, out hit1, dist, mask))
        {
            inTraffic = true;

        }
        else
        {
            inTraffic = false;
        }


    }


}

