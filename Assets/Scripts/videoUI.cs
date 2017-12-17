using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VideoUI : MonoBehaviour
{

    public VideoControler videoControler;

    public abstract void PlayPause();

    public abstract void Restart();
}