using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public AudioSource carHorn;
    public SpeedButtons speedButtonsScript;
    public Transform[] waypoints;
    public int setSpeed;
    private int newSpeed;

    private int waypointIndex;
    private float distance;
    private float maxSpeed;

    bool inTraffic = false;
    private bool carAlive = true;
    Animation brakeAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        carAlive = true;
        newSpeed = setSpeed;
        carHorn = GetComponent<AudioSource>();
        speedButtonsScript = GameObject.FindGameObjectWithTag("HUD").GetComponent<SpeedButtons>();

        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);

        brakeAnim = GetComponent<Animation>();
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

        if (waypointIndex == waypoints.Length)
            Destroy(this);
            
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
            Object.Destroy(this.gameObject);
            carAlive = false;
        }
    }


    void OnMouseDown()
    {
        carHorn.Play();
        StartCoroutine(SlowDownCar());
        //potential fix: - if this takes less than a second start speed up car
    }

    void OnMouseUp()
    {

        StartCoroutine(SpeedUpCar());
    }

    IEnumerator SlowDownCar()
    {
        while (setSpeed != 0)
        {
            brakeAnim.Play();
            setSpeed -= 1;
            yield return new WaitForSeconds(0.1f);
        }

    }

    IEnumerator SpeedUpCar()
    {
        while (setSpeed != newSpeed)
        {
            brakeAnim.Stop();
            yield return new WaitForSeconds(0.05f);
            setSpeed += 1;
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


        if (Physics.Raycast(transform.position, forward, out hit1, dist, mask))
        {
            inTraffic = true;
            brakeAnim.Play();
        }
        else
        {
            inTraffic = false;
            brakeAnim.Stop();
        }


    }


}

