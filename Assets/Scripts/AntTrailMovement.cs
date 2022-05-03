using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntTrailMovement : MonoBehaviour
{
    public float minimum;
    public float maximum;

    SpriteRenderer antSprites;

    bool antDirection = true;

    // starting value for the Lerp
    static float t = 0.0f;

    public float disToMove = 1f;

    private void Start()
    {
        antSprites = GetComponent<SpriteRenderer>();

        minimum = transform.position.x;
        maximum = transform.position.x + disToMove;
    }

    void Update()
    {
        // animate the position of the game object...
        transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), transform.position.y, transform.position.z);

        // .. and increase the t interpolater
        t += 0.2f * Time.deltaTime;



        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
            antSprites.flipY = antDirection;
            antDirection = !antDirection;
            
        }
    }
}