using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider sliderMaster;
    [SerializeField] private Slider sliderMusic;
    [SerializeField] private Slider sliderSFX;

    public void SetVolumeMaster()
    {
        float volume = sliderMaster.value;
        myMixer.SetFloat("Master", Mathf.Log10(volume)*20);
    }
    public void SetVolumeMusic()
    {
        float volume = sliderMusic.value;
        myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
    }

    public void SetVolumeSFX()
    {
        float volume = sliderSFX.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}
