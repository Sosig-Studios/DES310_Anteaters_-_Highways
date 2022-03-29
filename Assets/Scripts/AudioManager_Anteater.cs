using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_Anteater : MonoBehaviour
{



    public AudioSource SfxChime;
    public AudioSource SfxEat;
    public AudioSource SfxHit;

    // Start is called before the first frame update
    void Start()
    {
        SfxChime = gameObject.AddComponent<AudioSource>();
        SfxEat = gameObject.AddComponent<AudioSource>();
        SfxHit = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
