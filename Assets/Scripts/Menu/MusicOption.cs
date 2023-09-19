using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicOption : MonoBehaviour
{
    public static MusicOption Instance;
    public Slider music;
    public Slider sound;
    public TMP_Text musicText;
    public TMP_Text soundText;

    public float musicValume = 100f;
    public float soundValume = 100f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
        musicValume = PlayerPrefs.GetFloat("ValumeMusic");
        soundValume = PlayerPrefs.GetFloat("ValumeSound");
    }

    void Start()
    {
        // music.value = musicValume/100;
        // sound.value = soundValume/100;
    }

    void Update()
    {
        musicValume = music.value;
        
        SoundSystem.Instance.ToValumeMusic(musicValume*100);
        
        soundValume = sound.value;
        
        SoundSystem.Instance.ToValumeSounds(soundValume*100);

        int musVal = Mathf.FloorToInt(musicValume*100);
        int sounVal = Mathf.FloorToInt(soundValume*100);
        musicText.text = musVal.ToString();
        soundText.text = sounVal.ToString();
    }

    public void SaveSoundInMusic()
    {
        musicValume = music.value*100;
        soundValume = sound.value*100;
        PlayerPrefs.SetFloat("ValumeSound", soundValume*100);
        PlayerPrefs.SetFloat("ValumeMusic", musicValume*100);
    }

    public void NotSaveSoundInMusic()
    {
        musicValume = 100;
        soundValume = 100;
        PlayerPrefs.SetFloat("ValumeSound", soundValume*100);
        PlayerPrefs.SetFloat("ValumeMusic", musicValume*100);
    }
}