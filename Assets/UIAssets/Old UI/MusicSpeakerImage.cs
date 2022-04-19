using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSpeakerImage : MonoBehaviour
{
    public Image volumeImage;
    public Sprite MuteVolumeImage;
    public Sprite LowVolumeImage;
    public Sprite MidVolumeImage;
    public Sprite MaxVolumeImage;

    public void SetVolumeImage(float volume)
    {
        if(volume == 0f)
        {
            volumeImage.sprite = MuteVolumeImage;
        }
        else if (volume <= .25f)
        {
            volumeImage.sprite = LowVolumeImage;
        }
        else if (volume <= .50f)
        {
            volumeImage.sprite = MidVolumeImage;
        }
        else if (volume <= 1f)
        {
            volumeImage.sprite = MaxVolumeImage;
        }
        //0, 25, 50, 75
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
