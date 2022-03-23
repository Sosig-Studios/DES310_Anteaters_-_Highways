using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class deathCamera : MonoBehaviour
{
    public Camera sceneCam;
    public GameObject killedAnteater;
    CinemachineVirtualCamera virtualCam;

    public Transform followTarget;

    public Color normalBackground;
    public Color deathBackground;

    public float duration = 5f;
    public AnimationClip deathAnimation;

    // Start is called before the first frame update
    void Start()
    {
        virtualCam = sceneCam.GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    public void DeathScreen()
    {
        StartCoroutine("DeathAnimation");
    }

    public IEnumerator DeathAnimation()
    {
        followTarget = killedAnteater.transform;
        virtualCam.LookAt = followTarget;
        float t = Mathf.PingPong(Time.time, duration) / duration;
        sceneCam.backgroundColor = Color.Lerp(normalBackground, deathBackground, t);
        yield return new WaitForSeconds(2.2f);

        virtualCam.Follow = followTarget;
        killedAnteater.GetComponent<Animation>().wrapMode = WrapMode.Once;
        killedAnteater.GetComponent<Animation>().Play();
    }


}
