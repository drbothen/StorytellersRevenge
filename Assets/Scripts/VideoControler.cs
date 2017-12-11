using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoControler : MonoBehaviour {

    private UnityEngine.Video.VideoPlayer videoPlayer;
    public GameObject pauseSplash; //splash screen that displays Pause Gui
    public GameObject choiceSplash; //splash screen that displays choice Gui
    public float vidtimeupperband; // Upper Timer Band
    public float vidtimelowerband; // Lower Timer Band
    public float vidmidband; // Middle(ish) Timer Band
    private float count = 2f;

    [SerializeField]
    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();

        if (videoPlayer.clip != null) // if there is a video clip, enable
        {
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.SetTargetAudioSource(0, audioSource);
        }
    }
	
	// Update is called once per frame
	void Update () {
        //Play or pause the video from user input
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0) && (videoPlayer.time <= vidtimelowerband || videoPlayer.time >= vidtimeupperband))
        {
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
                audioSource.Pause();
                pauseSplash.SetActive(true);
            }

            else
            {
                videoPlayer.Play();
                audioSource.Play();
                pauseSplash.SetActive(false);
            }
        }

        else if (Input.GetMouseButton(0))
        {
            count -= Time.deltaTime;
            if (count < 0)
            {
                SceneManager.LoadScene("WaterfallAdventure");
                count = 2f;
            }

        }

        else if (Input.GetMouseButtonUp(0))
        {
            count = 2f;
        }

        //Debug.Log("count: " + count);

        if (videoPlayer.time >= vidmidband)
        {
            videoPlayer.Pause();
            audioSource.Pause();
            choiceSplash.SetActive(true);
        }
    }

}

