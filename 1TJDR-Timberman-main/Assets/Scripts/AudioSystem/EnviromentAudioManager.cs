using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnviromentAudioType
{
    Menu,
    Gameplay,
    GameOver
}

[RequireComponent(typeof(AudioSource))]
public class EnviromentAudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] enviromentAudios;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(EnviromentAudioType enviromentAudioType)
    {
        switch (enviromentAudioType)
        {
            case EnviromentAudioType.Menu:
                PlaySound(enviromentAudios[0]);
                break;

            case EnviromentAudioType.Gameplay:
                PlaySound(enviromentAudios[1]);
                break;

            case EnviromentAudioType .GameOver:
                PlaySound(enviromentAudios[2]);
                break;

            default:
                break;
        }
    }

    void PlaySound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
        print(audio);
    }


}
