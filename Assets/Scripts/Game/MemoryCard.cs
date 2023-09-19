using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SpriteRenderer imageBack;
    [SerializeField] private Animator anim;

    private int _id;
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    void Start()
    {
        // GetComponent<SpriteRenderer>().sprite = image;
    }

    public void SetCard(int id, Sprite image, Sprite back)
    {
        Id = id;
        GetComponent<SpriteRenderer>().sprite = image;
        imageBack.sprite = back;
    }

    public void OnMouseDown()
    {
        GameEvents.Instance.InvokeSoundCardEvent();
        if (cardBack.activeSelf)
        {
            // anim.SetBool("open", true);
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}
