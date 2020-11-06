using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioMixerControl : MonoBehaviour
{
	public AudioMixer masterMixer;
	public Slider audioSlider;
	public static float sound;

	public void AudioControl()
    {
		 float sound = audioSlider.value;

		if (sound == -40f)
		{
			masterMixer.SetFloat("masterVolume", -80);
		}
		else
		{
			masterMixer.SetFloat("masterVolume", sound);
		}
    }
	
}
