using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnviromentAudioType
{
    Menu,
    Gameplay,
    GameOver
}

public class EnviromentAudioManager : AudioABS
{

    public void PlaySoundByType(EnviromentAudioType audioType)
    {
        switch (audioType)
        {
            case EnviromentAudioType.Menu:
                print(EnviromentAudioType.Menu);
                //PlaySound(audioClips[0]);
                break;

            case EnviromentAudioType.Gameplay:
                print(EnviromentAudioType.Gameplay);
                //PlaySound(audioClips[1]);
                break;

            case EnviromentAudioType.GameOver:
                print(EnviromentAudioType.GameOver);
                //PlaySound(audioClips[2]);
                break;


        }
    }
}
