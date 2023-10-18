using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SFXAudioType
{
    OnClick,
    Hit,
    Hurt
}

[RequireComponent(typeof(AudioSource))]
public class SFXAudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] sfxAudios;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(SFXAudioType sfxAudioType)
    {
        switch (sfxAudioType)
        {
            case SFXAudioType.OnClick:
                PlaySound(sfxAudios[0]);
                break;

            case SFXAudioType.Hit:
                PlaySound(sfxAudios[1]);
                break;

            case SFXAudioType.Hurt:
                PlaySound(sfxAudios[2]);
                break;

            default:
                break;
        }
    }

    public void PlaySound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
        print(audio);
    }
}
