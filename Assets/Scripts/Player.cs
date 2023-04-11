using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public ChangeScene Cs;
    
    void Start()
    {
        rawImageVideo.SetActive(false);
    }

    public void playerAttack()
    {
        playerAnimator.SetTrigger("Play");
    }

    public void invokeVideo()
    {
        Invoke("PlayVideo", 10.0f);
    }

    public void playVideo()
    {
        rawImageVideo.SetActive(true);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(3.0f);
        Cs.ChangeMyScene("Menu");
    }
}

