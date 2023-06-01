using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;


    public void PlaySoundEffectStart()
    {
        audioSource.PlayOneShot(soundEffect);
    }
}
