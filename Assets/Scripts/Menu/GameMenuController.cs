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
    
    private bool _isPanel = false;

    public void OpenClosedMenu()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        _isPanel = !_isPanel;
        panelMenu.SetActive(_isPanel);
    }

    public void LoadScenes(string NextScene)
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        PlayerPrefs.SetString("backScene", NextScene);
        PlayerPrefs.SetString("nextScene", NextScene);
        SceneManager.LoadScene(SceneNameLoad);
    }

    public void Exit()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        // PlayerPrefs.SetInt("Ads", 0);
        Application.Quit();
    }
}
