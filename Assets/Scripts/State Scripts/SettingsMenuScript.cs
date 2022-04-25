using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour
{
    //Music//
    public Image volumeImage;
    public Sprite MuteVolumeImage;
    public Sprite LowVolumeImage;
    public Sprite MidVolumeImage;
    public Sprite MaxVolumeImage;

    //SFX//
    public Image sfxImage;
    public Sprite MuteSFXImage;
    public Sprite LowSFXImage;
    public Sprite MidSFXImage;
    public Sprite MaxSFXImage;

    //Brightness
    public Image levelBrightness;

    public void SetVolumeImage(float musicVolume)
    {
        if(musicVolume == 0f)
        {
            volumeImage.sprite = MuteVolumeImage;
        }
        else if (musicVolume <= .25f)
        {
            volumeImage.sprite = LowVolumeImage;
        }
        else if (musicVolume <= .50f)
        {
            volumeImage.sprite = MidVolumeImage;
        }
        else if (musicVolume <= 1f)
        {
            volumeImage.sprite = MaxVolumeImage;
        }
        //0, 25, 50, 75
    }

    public void SetSFXImage(float sfxVolume)
    {
        if(sfxVolume == 0f)
        {
            sfxImage.sprite = MuteSFXImage;
        }
        else if (sfxVolume <= .25f)
        {
            sfxImage.sprite = LowSFXImage;
        }
        else if (sfxVolume <= .50f)
        {
            sfxImage.sprite = MidSFXImage;
        }
        else if (sfxVolume <= 1f)
        {
            sfxImage.sprite = MaxSFXImage;
        }
        //0, 25, 50, 75
    }

    public void SetBrightness(float brightness)
    {
        Debug.Log("Brightness:" + brightness);
        
        Color c = levelBrightness.color;
        c.a = brightness;
        levelBrightness.color = c;
        //RenderSettings.ambientLight = new Color(brightness, brightness, brightness, 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        //maybe set volume and based off current volume
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
