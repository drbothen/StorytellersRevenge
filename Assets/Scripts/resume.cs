using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playback : MonoBehaviour {
    private UnityEngine.Video.VideoPlayer videoPlayer;

    public void Resume()
    {
        videoPlayer.Play();
    }

    public void Restart()
    {
        videoPlayer.Stop();
        videoPlayer.Play();
    }

}
