using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Options : MonoBehaviour
{
    public Toggle FullScreenToggle, VSyncToggle;
    
    public List<ResolutionItems> Resolutions = new List<ResolutionItems>();
    private int SelectedResolution;

    public TMP_Text ResolutionLabel;

    public AudioMixer theMixer;
    public TMP_Text MasterVolumeText, MusicVolumeText;
    public Slider MasterVolumeSlider, MusicVolumeSlider;

    void Start()
    {
        FullScreenToggle.isOn = Screen.fullScreen;

        if (QualitySettings.vSyncCount == 0)
        {
            VSyncToggle.isOn = false;
        }
        else
        {
            VSyncToggle.isOn = true;
        }

        bool foundResolution = false;

        for (int i = 0; i < Resolutions.Count; i++)
        {
            if (Screen.width == Resolutions[i].Horizontal && Screen.height == Resolutions[i].Vertical)
            {
                foundResolution = true;
                SelectedResolution = i;
                UpdateResolutionLabel();
            }
        }

        if (!foundResolution)
        {
            ResolutionItems newResolution = new ResolutionItems();
            newResolution.Horizontal = Screen.width;
            newResolution.Vertical = Screen.height;

            Resolutions.Add(newResolution);
            SelectedResolution = Resolutions.Count - 1;

            UpdateResolutionLabel();
        }

        float Volume = 0f;
        theMixer.GetFloat("MasterVolume", out Volume);
        MasterVolumeSlider.value = Volume;
        theMixer.GetFloat("MusicVolume", out Volume);
        MusicVolumeSlider.value = Volume;

        MasterVolumeText.text = Mathf.RoundToInt(MasterVolumeSlider.value + 80).ToString();
        MusicVolumeText.text = Mathf.RoundToInt(MusicVolumeSlider.value + 80).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResolutionLeft()
    {
        SelectedResolution--;

        if (SelectedResolution < 0)
        {
            SelectedResolution = 0;
        }

        UpdateResolutionLabel();
    }

    public void ResolutionRight()
    {
        SelectedResolution++;

        if (SelectedResolution > Resolutions.Count - 1)
        {
            SelectedResolution = Resolutions.Count - 1;
        }

        UpdateResolutionLabel();
    }

    public void UpdateResolutionLabel()
    {
        ResolutionLabel.text = Resolutions[SelectedResolution].Horizontal.ToString() + " x " + Resolutions[SelectedResolution].Vertical.ToString();
    }

    public void ApplyGraphicChanges()
    {
        //Screen.fullScreen = FullScreenToggle.isOn;
        
        if (VSyncToggle.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }

        Screen.SetResolution(Resolutions[SelectedResolution].Horizontal, Resolutions[SelectedResolution].Vertical, FullScreenToggle.isOn);
    }

    public void SetMasterVolume()
    {
        MasterVolumeText.text = Mathf.RoundToInt(MasterVolumeSlider.value + 80).ToString();

        theMixer.SetFloat("MasterVolume", MasterVolumeSlider.value);

        PlayerPrefs.SetFloat("MasterVolume", MasterVolumeSlider.value);
    }
    
    public void SetMusicVolume()
    {
        MusicVolumeText.text = Mathf.RoundToInt(MusicVolumeSlider.value + 80).ToString();

        theMixer.SetFloat("MusicVolume", MusicVolumeSlider.value);

        PlayerPrefs.SetFloat("MusicVolume", MusicVolumeSlider.value);
    }
}

[System.Serializable]
public class ResolutionItems
{
    public int Horizontal, Vertical;
}