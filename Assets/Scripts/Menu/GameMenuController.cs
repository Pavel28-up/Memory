using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    public string NextScene;
    public string SceneNameLoad = "LoadLobby";
    
    [SerializeField] private GameObject panelMenu;
    public int ads;
    
    private bool _isPanel = false;

    void Awake()
    {
        ads = PlayerPrefs.GetInt("Ads");
        if (ads == 3)
        {
            ads = 0;
            InterstitialAds.Instance.ShowAd();
        }
    }

    public void OpenClosedMenu()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        _isPanel = !_isPanel;
        panelMenu.SetActive(_isPanel);
    }

    public void LoadScenes(string NextScene)
    {
        ads++;
        if (NextScene.ToLower() == "Game".ToLower())
            PlayerPrefs.SetInt("Ads", ads);
        GameEvents.Instance.InvokeSoundButtonEvent();
        PlayerPrefs.SetString("backScene", NextScene);
        PlayerPrefs.SetString("nextScene", NextScene);
        SceneManager.LoadScene(SceneNameLoad);
    }

    public void Exit()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        PlayerPrefs.SetInt("Ads", 0);
        Application.Quit();
    }
}
