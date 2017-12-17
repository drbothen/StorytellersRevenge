using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playcontrols : VideoUI {
    //private UnityEngine.Video.VideoPlayer videoPlayer;

    public override void PlayPause()
    {
        videoControler.PlayPause();
        videoControler.pauseSplash.SetActive(false);
    }

    public override void Restart()
    {
        videoControler.Restart();
        videoControler.pauseSplash.SetActive(false);
    }

}
