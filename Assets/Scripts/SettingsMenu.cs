using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settings;
    public AudioMixer audioMix;
    public Slider volSlider;
    public void BackToMenu()
    {
        settings.SetActive(false);
    }

    public void SetVol(float vol)
    {
        AudioListener.volume = volSlider.value;
    }

    public void SetGraphics(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
    
}
