using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PlayBackgroundMusic : MonoBehaviour
{
    public List<AudioClip> backgroundClips = new List<AudioClip>();
    private AudioSource source;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        IsSourcePlaying();
    }

    void IsSourcePlaying()
    {
        if (!source.isPlaying)
        {
            int i =Random.Range(0, backgroundClips.Count);
            source.clip = backgroundClips[i];
            source.Play();
        }
    }
}
