using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip die;
    public AudioClip pass;

    public AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void SoundPlay(string kind)
    {
        switch(kind)
        {
            case "JUMP":
                audio.clip = jump; break;
            case "DIE":
                audio.clip = die; break;
            case "PASS":
                audio.clip = pass; break;
        }

        audio.PlayOneShot(audio.clip);
    }
}
