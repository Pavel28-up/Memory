using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController Instance;
    public string NextScene;
    public string SceneNameLoad = "LoadLobby";

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
        PlayerPrefs.SetInt("Ads", 0);
        Application.Quit();
    }
}
