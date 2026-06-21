using UnityEngine;
using System.Collections.Generic;

public class PlayBookFallingSound : MonoBehaviour
{

    public List<AudioClip> clips = new List<AudioClip>();
    private AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collison detected");
        if (other.tag == "Shelf")
        {
            Debug.Log("Hitting Shelf");
            PlaySounds();
        }
    }
    void PlaySounds()
    {
        int i = Random.Range(0, clips.Count);
        source.clip = clips[i];
        source.Play();
    }
}
