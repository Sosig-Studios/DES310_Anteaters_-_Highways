using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnteaterAnimationControlTest : MonoBehaviour
{
    Animator aeControler;

    // Start is called before the first frame update
    void Start()
    {
        aeControler = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("starts eating");
            aeControler.SetBool("isEating", true);
        }
        else if (Input.GetKeyUp("w"))
        {
            Debug.Log("stops eating");
            aeControler.SetBool("isEating", false);
        }
        else if (Input.GetKeyDown("s"))
        {
            Debug.Log("is dead");
            aeControler.SetBool("isDead", true);
        }
    }
}
