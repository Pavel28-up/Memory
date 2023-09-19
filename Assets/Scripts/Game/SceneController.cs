using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneController : MonoBehaviour
{
    public TMP_Text scoreText;
    public int gridRows = 2;
    public int gridCols = 4;
    public float offsetx = 2f;
    public float offsetY = 2.5f;

    [SerializeField] public MemoryCard originCard;
    [SerializeField] private Sprite[] images;
    [SerializeField] private Sprite imagesShirts;
    [SerializeField] private SpriteRenderer imagesTable;

    [SerializeField] private MemoryCard _firstRevealed;
    [SerializeField] private MemoryCard _secondRevealed;
    private int _score;

    public bool canRevealed
    {
        get
        {
            return _secondRevealed == null;
        }
    }
    
    void Start()
    {
        int[] numbers = GameController.Instance.OnCountCard();
        Vector3 startPos = originCard.transform.position;
        images = GameController.Instance.OnDeckCard();
        imagesShirts = GameController.Instance.OnShirtCard();
        imagesTable.sprite = GameController.Instance.OnTable();

        numbers = SurffleArray(numbers);

        for(int i = 0; i < gridCols; i++)
        {
            for(int j = 0; j < gridRows; j++)
            {
                MemoryCard card;
                if (i == 0 && j ==0)
                {
                    card = originCard;
                    // GameEvents.Instance.InvokeSoundCardEvent();
                }
                else
                {
                    card = Instantiate(originCard) as MemoryCard;
                    // GameEvents.Instance.InvokeSoundCardEvent();
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                card.SetCard(id, images[id], imagesShirts);

                float posX = (offsetx * i) + startPos.x;
                float posY = -(offsetY *j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
            }
        }
    }

    private int[] SurffleArray(int[] number)
    {
        int[] newArray = number.Clone() as int[];
        for(int i = 0; i < newArray.Length; i++)
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }

        return newArray;
    }

    public void CardRevealed(MemoryCard card)
    {
        if (_firstRevealed == null)
        {
            _firstRevealed = card;
        }
        else
        {
            _secondRevealed = card;
            Debug.Log("Match? " + (_firstRevealed.Id == _secondRevealed.Id));
            StartCoroutine(CheckMatch());
        }
    }

    private IEnumerator CheckMatch()
    {
        if (_firstRevealed.Id == _secondRevealed.Id)
        {
            _score += 3;
            scoreText.text = $"Score: {_score}";
        }
        else
        {
            yield return new WaitForSeconds(.5f);

            _firstRevealed.Unreveal();
            _secondRevealed.Unreveal();
        }

        _firstRevealed = null;
        _secondRevealed = null;
    }
}
