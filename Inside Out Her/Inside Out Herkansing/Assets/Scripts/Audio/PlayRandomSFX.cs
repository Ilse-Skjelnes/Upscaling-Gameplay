using UnityEngine;
using System.Collections.Generic;

public class PlayRandomSFX : MonoBehaviour
{
    public List<AudioClip> clips = new List<AudioClip>();
    public AudioSource source;

    public void PlaySFX()
    {
        int i = Random.Range(0, clips.Count);
        source.clip = clips[i];
        source.Play();
    }
}
