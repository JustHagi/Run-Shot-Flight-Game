using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SesAyar : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider ses_slider;

    private void Start()
    {
        ses_slider.value = PlayerPrefs.GetFloat("ses_degeri");
    }
    public void ses_degeri(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("ses_degeri", ses_slider.value);
    }

}
