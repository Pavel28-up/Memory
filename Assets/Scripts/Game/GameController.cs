using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    [SerializeField] private SceneController controller;
    [SerializeField] private MemoryCard originCard1;
    [SerializeField] private MemoryCard originCard2;
    [SerializeField] private MemoryCard originCard3;
    [SerializeField] private Sprite[] images1;
    [SerializeField] private Sprite[] images2;
    [SerializeField] private Sprite[] images3;
    [SerializeField] private Sprite[] images4;
    [SerializeField] private Sprite[] images5;
    [SerializeField] private Sprite[] images6;
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
    [SerializeField] private string _nameDeck;

    private Sprite[] newImage;
    private Sprite newImageShirt;
    private Sprite newImageTable;
    private int _idShirt;
    private int _idTable;
    private int _countCard = 4;
    private int[] numbers;

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
        _idShirt = PlayerPrefs.GetInt("_idShirt");
        _idTable = PlayerPrefs.GetInt("_idTable");
        _countCard = PlayerPrefs.GetInt("_countCard");
    }

    void Start()
    {
        _nameDeck = PlayerPrefs.GetString("NamesDeck");
        nameDeck1 = PlayerPrefs.GetString("nameDeck1");
        nameDeck2 = PlayerPrefs.GetString("nameDeck2");
        nameDeck3 = PlayerPrefs.GetString("nameDeck3");
        nameDeck4 = PlayerPrefs.GetString("nameDeck4");
        nameDeck5 = PlayerPrefs.GetString("nameDeck5");
        nameDeck6 = PlayerPrefs.GetString("nameDeck6");
    }

    public Sprite[] OnDeckCard()
    {
        
        if (_nameDeck.ToLower() == nameDeck1.ToLower())
        {
            newImage = images1.Clone() as Sprite[];
        }
        else if (_nameDeck.ToLower() == nameDeck2.ToLower())
        {
            newImage = images2.Clone() as Sprite[];
        }
        else if (_nameDeck.ToLower() == nameDeck3.ToLower())
        {
            newImage = images3.Clone() as Sprite[];
        }
        else if (_nameDeck.ToLower() == nameDeck4.ToLower())
        {
            newImage = images4.Clone() as Sprite[];
        }
        else if (_nameDeck.ToLower() == nameDeck5.ToLower())
        {
            newImage = images5.Clone() as Sprite[];
        }
        else if (_nameDeck.ToLower() == nameDeck6.ToLower())
        {
            newImage = images6.Clone() as Sprite[];
        }
        
        return newImage;
        
    }

    public Sprite OnShirtCard()
    {
        if (_nameDeck.ToLower() == nameDeck1.ToLower())
        {
            newImageShirt = imageShirt1[_idShirt];
        }
        else if (_nameDeck.ToLower() == nameDeck2.ToLower())
        {
            newImageShirt = imageShirt2[_idShirt];
        }
        else if (_nameDeck.ToLower() == nameDeck3.ToLower())
        {
            newImageShirt = imageShirt3[_idShirt];
        }
        else if (_nameDeck.ToLower() == nameDeck4.ToLower())
        {
            newImageShirt = imageShirt4[_idShirt];
        }
        else if (_nameDeck.ToLower() == nameDeck5.ToLower())
        {
            newImageShirt = imageShirt5[_idShirt];
        }
        else if (_nameDeck.ToLower() == nameDeck6.ToLower())
        {
            newImageShirt = imageShirt6[_idShirt];
        }
        return newImageShirt;
    }

    public Sprite OnTable()
    {
        if (_nameDeck.ToLower() == nameDeck1.ToLower())
        {
            newImageTable = imageTable1[_idTable];
        }
        else if (_nameDeck.ToLower() == nameDeck2.ToLower())
        {
            newImageTable = imageTable2[_idTable];
        }
        else if (_nameDeck.ToLower() == nameDeck3.ToLower())
        {
            newImageTable = imageTable3[_idTable];
        }
        else if (_nameDeck.ToLower() == nameDeck4.ToLower())
        {
            newImageTable = imageTable4[_idTable];
        }
        else if (_nameDeck.ToLower() == nameDeck5.ToLower())
        {
            newImageTable = imageTable5[_idTable];
        }
        else if (_nameDeck.ToLower() == nameDeck6.ToLower())
        {
            newImageTable = imageTable6[_idTable];
        }
        return newImageTable;
    }


    public int[] OnCountCard()
    {
        if (_countCard == 4)
        {
            numbers = new int [_countCard*2];
            controller.gridCols = 4;
            controller.gridRows = 2;
            controller.offsetx = 3;
            controller.offsetY = 4;
            originCard1.gameObject.SetActive(true);
            controller.originCard = originCard1;
            originCard2.gameObject.SetActive(false);
            originCard3.gameObject.SetActive(false);
            numbers[0] = 0;
            numbers[1] = 0;
            numbers[2] = 1;
            numbers[3] = 1;
            numbers[4] = 2;
            numbers[5] = 2;
            numbers[6] = 3;
            numbers[7] = 3;
        }
        if (_countCard == 8)
        {
            numbers = new int [_countCard*2];
            controller.gridCols = 8;
            controller.gridRows = 2;
            controller.offsetx = 2;
            controller.offsetY = 4;
            originCard1.gameObject.SetActive(false);
            originCard2.gameObject.SetActive(true);
            controller.originCard = originCard2;
            originCard3.gameObject.SetActive(false);
            numbers[0] = 0;
            numbers[1] = 0;
            numbers[2] = 1;
            numbers[3] = 1;
            numbers[4] = 2;
            numbers[5] = 2;
            numbers[6] = 3;
            numbers[7] = 3;
            numbers[8] = 4;
            numbers[9] = 4;
            numbers[10] = 5;
            numbers[11] = 5;
            numbers[12] = 6;
            numbers[13] = 6;
            numbers[14] = 7;
            numbers[15] = 7;
        }
        if (_countCard == 12)
        {
            numbers = new int [_countCard*2];
            controller.gridCols = 6;
            controller.gridRows = 4;
            controller.offsetx = 2;
            controller.offsetY = 2.1f;
            originCard1.gameObject.SetActive(false);
            originCard2.gameObject.SetActive(false);
            originCard3.gameObject.SetActive(true);
            controller.originCard = originCard3;
            
            numbers[0] = 0;
            numbers[1] = 0;
            numbers[2] = 1;
            numbers[3] = 1;
            numbers[4] = 2;
            numbers[5] = 2;
            numbers[6] = 3;
            numbers[7] = 3;
            numbers[8] = 4;
            numbers[9] = 4;
            numbers[10] = 5;
            numbers[11] = 5;
            numbers[12] = 6;
            numbers[13] = 6;
            numbers[14] = 7;
            numbers[15] = 7;
            numbers[16] = 8;
            numbers[17] = 8;
            numbers[18] = 9;
            numbers[19] = 9;
            numbers[20] = 10;
            numbers[21] = 10;
            numbers[22] = 11;
            numbers[23] = 11;
        }

        return numbers;
    }
}
