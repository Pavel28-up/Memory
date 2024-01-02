using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OptionController : MonoBehaviour
{
    public string NextScene;
    public string SceneNameLoad = "LoadLobby";

    [SerializeField] private GameObject panelDeck;
    [SerializeField] private GameObject panelRules;
    [SerializeField] private GameObject panelDeckCard;
    [SerializeField] private TMP_Text nameDeckBut;
    [SerializeField] private TMP_Text countCardText;
    [SerializeField] private Image iconFace;
    [SerializeField] private Image iconShirt;
    [SerializeField] private Image iconTable;
    [SerializeField] private Sprite[] image1;
    [SerializeField] private Sprite[] image2;
    [SerializeField] private Sprite[] image3;
    [SerializeField] private Sprite[] image4;
    [SerializeField] private Sprite[] image5;
    [SerializeField] private Sprite[] image6;
    [SerializeField] private Sprite[] imageShirt1;
    [SerializeField] private Sprite[] imageShirt2;
    [SerializeField] private Sprite[] imageShirt3;
    [SerializeField] private Sprite[] imageShirt4;
    [SerializeField] private Sprite[] imageShirt5;
    [SerializeField] private Sprite[] imageShirt6;
    [SerializeField] private Sprite[] imageTable1;
    [SerializeField] private Sprite[] imageTable2;
    [SerializeField] private Sprite[] imageTable3;
    [SerializeField] private Sprite[] imageTable4;
    [SerializeField] private Sprite[] imageTable5;
    [SerializeField] private Sprite[] imageTable6;
    [SerializeField] private string nameDeck1;
    [SerializeField] private string nameDeck2;
    [SerializeField] private string nameDeck3;
    [SerializeField] private string nameDeck4;
    [SerializeField] private string nameDeck5;
    [SerializeField] private string nameDeck6;


    private bool _isDeck;
    private bool _isRules = false;
    private bool _isDeckCard = false;
    private int _idShirt;
    private int _idTable;
    private int _countCard = 4;

    void Start()
    {
        PlayerPrefs.SetString("nameDeck1",nameDeck1);
        PlayerPrefs.SetString("nameDeck2",nameDeck2);
        PlayerPrefs.SetString("nameDeck3",nameDeck3);
        PlayerPrefs.SetString("nameDeck4",nameDeck4);
        PlayerPrefs.SetString("nameDeck5",nameDeck5);
        PlayerPrefs.SetString("nameDeck6",nameDeck6);
    }

    public void OnOpenCloseDeck()
    {
        _isDeck = true;
        _isRules = false;
        panelDeck.SetActive(_isDeck);
        panelRules.SetActive(_isRules);
        GameEvents.Instance.InvokeSoundButtonEvent();
    }

    public void OnOpenCloseRules()
    {
        _isRules = true;
        _isDeck = false;
        panelRules.SetActive(_isRules);
        panelDeck.SetActive(_isDeck);
        GameEvents.Instance.InvokeSoundButtonEvent();
    }

    public void OpenDeckCard()
    {
        _isDeckCard = !_isDeckCard;
        panelDeckCard.SetActive(_isDeckCard);
        GameEvents.Instance.InvokeSoundButtonEvent();
    }
    
    public void Isdeck(string nameDec)
    {
        if (nameDec.ToLower() == nameDeck1.ToLower())
        {
            iconFace.sprite = image1[0];
            iconShirt.sprite = image1[1];
            iconTable.sprite = image1[2];
            nameDeckBut.text = nameDeck1;
        }
        if (nameDec.ToLower() == nameDeck2.ToLower())
        {
            iconFace.sprite = image2[0];
            iconShirt.sprite = image2[1];
            iconTable.sprite = image2[2];
            nameDeckBut.text = nameDeck2;
        }
        if (nameDec.ToLower() == nameDeck3.ToLower())
        {
            iconFace.sprite = image3[0];
            iconShirt.sprite = image3[1];
            iconTable.sprite = image3[2];
            nameDeckBut.text = nameDeck3;
        }
        if (nameDec.ToLower() == nameDeck4.ToLower())
        {
            iconFace.sprite = image4[0];
            iconShirt.sprite = image4[1];
            iconTable.sprite = image4[2];
            nameDeckBut.text = nameDeck4;
        }
        if (nameDec.ToLower() == nameDeck5.ToLower())
        {
            iconFace.sprite = image5[0];
            iconShirt.sprite = image5[1];
            iconTable.sprite = image5[2];
            nameDeckBut.text = nameDeck5;
        }
        if (nameDec.ToLower() == nameDeck6.ToLower())
        {
            iconFace.sprite = image6[0];
            iconShirt.sprite = image6[1];
            iconTable.sprite = image6[2];
            nameDeckBut.text = nameDeck6;
        }

        OpenDeckCard();
        _idShirt = 0;
        _idTable = 0;
        GameEvents.Instance.InvokeSoundButtonEvent();
    }

    public void ShirtNext()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        _idShirt++;
        if (nameDeckBut.text.ToString().ToLower() == nameDeck1.ToLower())
        {
            if (_idShirt >= imageShirt1.Length)
            {
                _idShirt = 0;
                iconShirt.sprite = imageShirt1[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt1[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck2.ToLower())
        {
            if (_idShirt >= imageShirt2.Length)
            {
                _idShirt = 0;
                iconShirt.sprite = imageShirt2[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt2[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck3.ToLower())
        {
            if (_idShirt >= imageShirt3.Length)
            {
                _idShirt = 0;
                iconShirt.sprite = imageShirt3[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt3[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck4.ToLower())
        {
            if (_idShirt >= imageShirt4.Length)
            {
                _idShirt = 0;
                iconShirt.sprite = imageShirt4[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt4[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck5.ToLower())
        {
            if (_idShirt >= imageShirt5.Length)
            {
                _idShirt = 0;
                iconShirt.sprite = imageShirt5[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt5[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck6.ToLower())
        {
            if (_idShirt >= imageShirt6.Length)
            {
                _idShirt = 0;
                iconShirt.sprite = imageShirt6[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt6[_idShirt];
            }
        }
    }

    public void ShirtBack()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        _idShirt--;
        if (nameDeckBut.text.ToString().ToLower() == nameDeck1.ToLower())
        {
            if (_idShirt < 0)
            {
                _idShirt = imageShirt1.Length-1;
                iconShirt.sprite = imageShirt1[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt1[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck2.ToLower())
        {
            if (_idShirt < 0)
            {
                _idShirt = imageShirt2.Length-1;
                iconShirt.sprite = imageShirt2[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt2[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck3.ToLower())
        {
            if (_idShirt < 0)
            {
                _idShirt = imageShirt3.Length-1;
                iconShirt.sprite = imageShirt3[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt3[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck4.ToLower())
        {
            if (_idShirt < 0)
            {
                _idShirt = imageShirt4.Length-1;
                iconShirt.sprite = imageShirt4[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt4[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck5.ToLower())
        {
            if (_idShirt < 0)
            {
                _idShirt = imageShirt5.Length-1;
                iconShirt.sprite = imageShirt5[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt5[_idShirt];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck6.ToLower())
        {
            if (_idShirt < 0)
            {
                _idShirt = imageShirt6.Length-1;
                iconShirt.sprite = imageShirt6[_idShirt];
            }
            else
            {
                iconShirt.sprite = imageShirt6[_idShirt];
            }
        }
    }

    public void TableNext()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        _idTable++;
        if (nameDeckBut.text.ToString().ToLower() == nameDeck1.ToLower())
        {
            if (_idTable >= imageTable1.Length)
            {
                _idTable = 0;
                iconTable.sprite = imageTable1[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable1[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck2.ToLower())
        {
            if (_idTable >= imageTable2.Length)
            {
                _idTable = 0;
                iconTable.sprite = imageTable2[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable2[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck3.ToLower())
        {
            if (_idTable >= imageTable3.Length)
            {
                _idTable = 0;
                iconTable.sprite = imageTable3[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable3[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck4.ToLower())
        {
            if (_idTable >= imageTable4.Length)
            {
                _idTable = 0;
                iconTable.sprite = imageTable4[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable4[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck5.ToLower())
        {
            if (_idTable >= imageTable5.Length)
            {
                _idTable = 0;
                iconTable.sprite = imageTable5[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable5[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck6.ToLower())
        {
            if (_idTable >= imageTable6.Length)
            {
                _idTable = 0;
                iconTable.sprite = imageTable6[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable6[_idTable];
            }
        }
    }

    public void TableBack()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        _idTable--;
        if (nameDeckBut.text.ToString().ToLower() == nameDeck1.ToLower())
        {
            if (_idTable < 0)
            {
                _idTable = imageTable1.Length-1;
                iconTable.sprite = imageTable1[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable1[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck2.ToLower())
        {
            if (_idTable < 0)
            {
                _idTable = imageTable2.Length-1;
                iconTable.sprite = imageTable2[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable2[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck3.ToLower())
        {
            if (_idTable < 0)
            {
                _idTable = imageTable3.Length-1;
                iconTable.sprite = imageTable3[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable3[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck4.ToLower())
        {
            if (_idTable < 0)
            {
                _idTable = imageTable4.Length-1;
                iconTable.sprite = imageTable4[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable4[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck5.ToLower())
        {
            if (_idTable < 0)
            {
                _idTable = imageTable5.Length-1;
                iconTable.sprite = imageTable5[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable5[_idTable];
            }
        }
        if (nameDeckBut.text.ToString().ToLower() == nameDeck6.ToLower())
        {
            if (_idTable < 0)
            {
                _idTable = imageTable6.Length-1;
                iconTable.sprite = imageTable6[_idTable];
            }
            else
            {
                iconTable.sprite = imageTable6[_idTable];
            }
        }
    }

    public void AddCardCount()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        int cou = int.Parse(countCardText.text.ToString());
        _countCard += 4;
        if (_countCard <= 12)
        {
            
            countCardText.text = $"{_countCard}";
        }
        else
        {
            _countCard = 4;
            countCardText.text = $"{_countCard}";
        }
    }
    public void RemoveCardCount()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        int cou = int.Parse(countCardText.text.ToString());
        _countCard -= 4;
        if (_countCard < 4)
        {
            _countCard = 12;
            countCardText.text = $"{_countCard}";
        }
        else
        {
            countCardText.text = $"{_countCard}";
        }
    }

    public void OnSoundSave()
    {
        StartCoroutine(SaveSetings());
    }
    private IEnumerator SaveSetings()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();
        
        yield return new WaitForSeconds(.5f);
        
        MusicOption.Instance.SaveSoundInMusic();
        PlayerPrefs.SetString("NamesDeck", nameDeckBut.text);
        PlayerPrefs.SetInt("_idShirt", _idShirt);
        PlayerPrefs.SetInt("_idTable", _idTable);
        PlayerPrefs.SetInt("_countCard", _countCard);

        PlayerPrefs.SetString("backScene", NextScene);
        PlayerPrefs.SetString("nextScene", NextScene);
        SceneManager.LoadScene(SceneNameLoad);
    }

    public void OnSoundNotSave()
    {
        StartCoroutine(DontSaveSetings());
    }

    private IEnumerator DontSaveSetings()
    {
        GameEvents.Instance.InvokeSoundButtonEvent();

        yield return new WaitForSeconds(.5f);

        MusicOption.Instance.NotSaveSoundInMusic();
        PlayerPrefs.SetString("NamesDeck", nameDeck1);
        PlayerPrefs.SetInt("_idShirt", 0);
        PlayerPrefs.SetInt("_idTable", 0);
        PlayerPrefs.SetInt("_countCard", 4);

        PlayerPrefs.SetString("backScene", NextScene);
        PlayerPrefs.SetString("nextScene", NextScene);
        SceneManager.LoadScene(SceneNameLoad);
    }
}
