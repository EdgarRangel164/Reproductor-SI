using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button playButton;
    
    void Start()
    {
        playButton.onClick.AddListener(PlayVideo);
    }

    void PlayVideo()
    {
        if (videoPlayer != null) {

            videoPlayer.Play();
    }
   
    {
        
    }
}
