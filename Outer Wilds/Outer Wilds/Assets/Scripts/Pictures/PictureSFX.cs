using UnityEngine;
using System.Collections.Generic;
public class PictureSFX : MonoBehaviour
{

    public AudioSource aSource;
    public List<AudioClip> clips = new List<AudioClip>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioClip()
    {
        int i = Random.Range(0, clips.Count - 1);
        aSource.clip = clips[i];
        aSource.Play();
    }
}
