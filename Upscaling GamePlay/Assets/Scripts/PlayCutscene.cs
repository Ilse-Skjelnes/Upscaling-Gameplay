using UnityEngine;
using UnityEngine.Video;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;
public class PlayCutscene : MonoBehaviour
{
    [SerializeField] private VideoPlayer cutscenePlayer;
    [SerializeField] private GameObject thePlayer;

    [SerializeField] private List<VideoClip> clipList = new List<VideoClip>();
    [SerializeField] private int clipIndex;



    private void OnEnable()
    {
        thePlayer.SetActive(true);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        clipIndex = GameManager.cutsceneIndex;
        cutscenePlayer.clip = clipList[clipIndex];

        cutscenePlayer.Prepare();
        StartCoroutine(PlayVideoWhenPrepared());

    }

    // Update is called once per frame
    void Update()
    {
        HidePlayer();
    }

    private void HidePlayer()
    {
        if (cutscenePlayer.isPaused)
        {
            thePlayer.SetActive(false);
        }
    }

    private IEnumerator PlayVideoWhenPrepared()
    {
        while (!cutscenePlayer.isPrepared)
        {
            yield return null;
        }


        cutscenePlayer.Play();
    }
}
