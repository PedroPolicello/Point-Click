using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static GameSystem instance;
    [SerializeField] private AudioSystem audioSystem;

    private void Awake()
    {
        //Singleton
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        PlayEnviromentAudioByType(EnviromentAudioType.Menu);
        audioSystem.PlayEnviromentAudioByType(EnviromentAudioType.Menu);
    }

    public void PlayEnviromentAudioByType(EnviromentAudioType audioType)
    {
        audioSystem.PlayEnviromentAudioByType(audioType);
    }

    public void PlayerSFXAudioByType(SFXAudioType audioType)
    {
        audioSystem.PlaySFXAudioByType(audioType);
    }
}
