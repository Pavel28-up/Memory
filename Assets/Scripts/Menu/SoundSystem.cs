using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem Instance;

    public AudioSource clipMusic;
    [SerializeField] private AudioClip soundsButtonClips;
    private AudioSource _soundsButton;
    [SerializeField] private AudioClip soundsCardClips;
    private AudioSource _soundsCard;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        _soundsCard = ConvertClipToConponent(soundsCardClips);
        _soundsButton = ConvertClipToConponent(soundsButtonClips);
        OnEnabled();
        ToValumeMusic(PlayerPrefs.GetFloat("ValumeMusic")/100);
        ToValumeSounds(PlayerPrefs.GetFloat("ValumeSound")/100);
    }

    private void OnEnabled()
    {
        GameEvents.Instance.OnSoundButtonValeme += SoundButton;
        GameEvents.Instance.OnSoundCardValeme += SoundCard;
    }

    private void OnDisabled()
    {
        GameEvents.Instance.OnSoundButtonValeme -= SoundButton;
        GameEvents.Instance.OnSoundCardValeme -= SoundCard;
    }

    private void SoundButton()
    {
        _soundsButton.PlayOneShot(soundsButtonClips);
    }

    private void SoundCard()
    {
        _soundsCard.PlayOneShot(soundsCardClips);
    }

    private AudioSource ConvertClipToConponent(AudioClip clipToConvert)
    {
        AudioSource shootingSource = gameObject.AddComponent<AudioSource>();
        shootingSource.clip = clipToConvert;
        shootingSource.playOnAwake = false;
        shootingSource.volume = 1f;
        return shootingSource;
    }

    public void ToValumeMusic(float music)
    {
        
        clipMusic.volume = music / 100f;
    }

    public void ToValumeSounds(float sound)
    {
        
        _soundsButton.volume = sound / 100f;

        _soundsCard.volume = sound / 100f;
    }
}
