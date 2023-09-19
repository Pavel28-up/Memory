using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;
    public delegate void Action();
    public event Action OnMusicVulume;
    public event Action OnSoundButtonValeme;
    public event Action OnSoundCardValeme;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }

    public void InvokeMusicEvent()
    {
        OnMusicVulume?.Invoke();
    }

    public void InvokeSoundButtonEvent()
    {
        OnSoundButtonValeme?.Invoke();
    }

    public void InvokeSoundCardEvent()
    {
        OnSoundCardValeme?.Invoke();
    }
}
