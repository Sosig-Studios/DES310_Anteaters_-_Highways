using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renameAnimationTest : MonoBehaviour
{
    Animator aeAnim;

    // Start is called before the first frame update
    void Start()
    {
        aeAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            aeAnim.SetBool("isEating", true);
        }
        else if (Input.GetKeyUp("e"))
        {
            aeAnim.SetBool("isEating", false);
        }
        else if (Input.GetKeyUp("a"))
        {
            aeAnim.SetBool("isDeadLeft", true);
        }
        else if (Input.GetKeyUp("d"))
        {
            aeAnim.SetBool("isDeadRight", true);
        }



    }
}
