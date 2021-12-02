using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Card {
    [SerializeField] public int id;
    [SerializeField] public string cardName;
    [SerializeField] public int cost;
    [SerializeField] public int damage;
    [SerializeField] public int life;
    [SerializeField] public string cardDescription;
    [SerializeField] public Sprite cardImage;
    public Card() {

    }

    public Card (int id, string cardName, int cost, int damage, int life, string cardDescription, Sprite cardImage) {
        this.id = id;
        this.cardName = cardName;
        this.cost = cost;
        this.damage = damage;
        this.life = life;
        this.cardDescription = cardDescription;
        this.cardImage = cardImage;
    }

}
