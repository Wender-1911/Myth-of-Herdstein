using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardBase : MonoBehaviour
{

    [SerializeField] private List<Card> thisCard = new List<Card>();
    [SerializeField] private int cardIdIdentify;

    [SerializeField] private int id;
    [SerializeField] private string cardName;
    [SerializeField] private int cost;
    [SerializeField] private int damage;
    [SerializeField] private int life;
    [SerializeField] private string cardDescription;

    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text costText;
    [SerializeField] private TMP_Text damageText;
    [SerializeField] private TMP_Text lifeText;

    [SerializeField] private Sprite cardSprite;
    [SerializeField] private Image cardImage;

    [SerializeField] public bool cardBack;
    [SerializeField] public CardBack cardBackScript;

    void Start() {
        thisCard[0] = CardDataBase.cardList[cardIdIdentify];

        cardBackScript = GetComponent<CardBack>();
    }
    void Update() {
        id = thisCard[0].id;
        cardName = thisCard[0].cardName;
        cost = thisCard[0].cost;
        damage = thisCard[0].damage;
        life = thisCard[0].life;
        cardSprite = thisCard[0].cardImage;

        nameText.text = cardName;
        costText.text = cost.ToString();
        damageText.text = damage.ToString();
        lifeText.text = life.ToString();
        cardImage.sprite = cardSprite;

        cardBackScript.UpdateCard(cardBack);
    }
}
