using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SFXAudioType
{
    OnClick,
    TimberHit,
    PlayerHurt
}

public class SFXAudioManager : AudioABS
{
    public void PlaySoundByType(SFXAudioType audioType)
    {
        switch (audioType)
        {
            case SFXAudioType.OnClick:
                print(SFXAudioType.OnClick);
                //PlaySound(audioClips[0]);
                break;

            case SFXAudioType.TimberHit:
                print(SFXAudioType.TimberHit);
                //PlaySound(audioClips[1]);
                break;

            case SFXAudioType.PlayerHurt:
                print(SFXAudioType.PlayerHurt);
                //PlaySound(audioClips[2]);
                break;
        }
    }

}
