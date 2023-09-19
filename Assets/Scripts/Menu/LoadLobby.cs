using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class LoadLobby : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image LoadImag;
    public TMP_Text LoadText;
    public string NextScene;
    public string BackScene;

    private float progress;

    void Start()
    {
        BackScene = PlayerPrefs.GetString("nextScene");
        PlayerPrefs.SetString("backScene", BackScene);
        NextScene = PlayerPrefs.GetString("nextScene");

        StartCoroutine(LoadSceneCor());
    }

    void Update()
    {
        LoadText.text = "Loading: " + Mathf.FloorToInt(progress * 100) + "%";
    }

    IEnumerator LoadSceneCor()
    {
        yield return new WaitForSeconds(1f);

        asyncOperation = SceneManager.LoadSceneAsync(NextScene);

        while (!asyncOperation.isDone)
        {
            progress = asyncOperation.progress / 0.9f;
            LoadImag.fillAmount = progress;
            LoadText.text = "Loading: " + Mathf.FloorToInt(progress * 100) + "%";
            yield return 0;
        }
    }
}
