using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoControler : MonoBehaviour
{

    private UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject pauseSplash; //splash screen that displays Pause Gui
    public GameObject choiceSplash; //splash screen that displays choice Gui

    //[SerializeField]
    //private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.loopPointReached += EndReached;

    }

    // Update is called once per frame
    void Update()
    {
        //Play or pause the video from user input
        if (Input.GetKeyDown("space") ||
            Input.GetMouseButtonDown(0))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
                pauseSplash.SetActive(true);
            }

            else
            {
                videoPlayer.Play();
                pauseSplash.SetActive(false);
            }
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        vp.Pause();
        choiceSplash.SetActive(true);
    }
}

