using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class LoadLobby1 : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image loadBar;
    public TMP_Text barTxt;
    [SerializeField] private string nameDeck1;
    public int sceneId;

    private float progress;

    void Awake()
    {
        if (PlayerPrefs.GetString("NamesDeck") == "")
        {
            PlayerPrefs.SetString("NamesDeck", nameDeck1);
            PlayerPrefs.SetInt("_idShirt", 0);
            PlayerPrefs.SetInt("_idTable", 0);
            PlayerPrefs.SetInt("_countCard", 4);
            PlayerPrefs.SetFloat("ValumeSound", 100*100);
            PlayerPrefs.SetFloat("ValumeMusic", 100*100);
        }
    }

    private void Start()
    {
        StartCoroutine(LoadSceneCorId());
    }

    private void Update()
    {
        barTxt.text = "Loading: " + Mathf.FloorToInt(progress * 100) + "%";
    }


    IEnumerator LoadSceneCorId()
    {
        yield return new WaitForSeconds(1f);
        asyncOperation = SceneManager.LoadSceneAsync(sceneId);
        while (!asyncOperation.isDone)
        {
            progress = asyncOperation.progress / 0.9f;
            loadBar.fillAmount = progress;
            barTxt.text = "Loading: " + Mathf.FloorToInt(progress * 100) + "%";
            yield return 0;
        }
    }
}
