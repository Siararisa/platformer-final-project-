using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
        source.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
            Destroy(this.gameObject);
    }

    public void PlayClip(string audioName)
    {
        source.clip = Resources.Load<AudioClip>("Audio/" + audioName);
        gameObject.name = "clip_" + audioName;
        source.Play();
    }
}
