using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;

    private int waypointIndex;
    private float distance;
    private float maxSpeed;

    bool inTraffic = false;
    
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
        maxSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        TrafficDetect();
        distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (distance < 1f)
        {
            IncreaseIndex();
        }
        if(!inTraffic)
            Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }

    void DeleteCar()
    {
        if(waypointIndex >= waypoints.Length)
        {

        }
    }


    void OnMouseDown()
    {
        //speed = 0;
        //Destroy(gameObject);
        StartCoroutine(SlowDownCar());
    }

    void OnMouseUp()
    {
        Debug.Log("Mouse Up");

        StartCoroutine(SpeedUpCar());
    }

    IEnumerator SlowDownCar()
    {
        while (speed != 0)
        {
            speed -= 1;
            yield return new WaitForSeconds(0.1f);
        }

    }

    IEnumerator SpeedUpCar()
    {
        while (maxSpeed != speed)
        {
            speed += 1;
            yield return new WaitForSeconds(0.1f);
        }
    }
    void TrafficDetect()
    {

        LayerMask mask = (1 << 8);


        var dist = 5.0f;
        var sdist = 3.0f;

        RaycastHit hit1;
        RaycastHit hit2;
        RaycastHit hit3;
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

/*
stop cars on click
collision with anteater

    IEnumerator SlowDownCar()
    {
        float maxSpeed = speed;
        while (speed != 0)
        {
            speed -= 1;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.3f);
        while (maxSpeed != speed)
        {
            speed += 1;
            yield return new WaitForSeconds(0.1f);
        }
    }

*/