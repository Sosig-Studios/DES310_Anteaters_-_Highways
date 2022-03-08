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
        distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (distance < 1f)
        {
            IncreaseIndex();
        }
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