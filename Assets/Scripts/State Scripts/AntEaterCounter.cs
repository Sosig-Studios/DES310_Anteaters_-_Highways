using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntEaterCounter : MonoBehaviour
{
    public int maxCounter;

    public Image counterImage;
    public Sprite counter1Image;
    public Sprite counter2Image;
    public Sprite counter3Image;
    public Sprite counter4Image;
    public Sprite counter5Image;

    private int currentCounter;

    // Start is called before the first frame update
    void Start()
    {
        currentCounter = maxCounter;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentCounter)
        {
            case 0:
                counterImage.sprite = counter1Image;
                break;
            case 1:
                counterImage.sprite = counter1Image;
                break;
            case 2:
                counterImage.sprite = counter2Image;
                break;
            case 3:
                counterImage.sprite = counter3Image;
                break;
            case 4:
                counterImage.sprite = counter4Image;
                break;
            case 5:
                counterImage.sprite = counter5Image;
                break;
            default:
                // code block
                counterImage.sprite = counter1Image;
                break;
        }
    }

    public void setCounterDown() { currentCounter -= 1; }
}
