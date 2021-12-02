using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour {
    [SerializeField] public List<Card> deck = new List<Card>();
    [SerializeField] public List<Card> deckContainer = new List<Card>();

    [SerializeField] private int deckLength;

    [SerializeField] private int cardNumberGenerator;

    [SerializeField] public GameObject cardInDeck1;
    [SerializeField] public GameObject cardInDeck2;
    [SerializeField] public GameObject cardInDeck3;
    [SerializeField] public GameObject cardInDeck4;

    [SerializeField] public GameObject cardBack;
    [SerializeField] public GameObject deckCopy;

    [SerializeField] public GameObject[] clones;

    private void Start() {
        cardNumberGenerator = 0;
        deckLength = 40;

        for (int i = 0; i < deckLength; i++) {
            cardNumberGenerator = Random.Range(1, 3);
            deck[i] = CardDataBase.cardList[cardNumberGenerator];
        }
    }
    private void Update() {
        if (deckLength < 30) {
            cardInDeck1.SetActive(false);
        }
        if (deckLength < 20) {
            cardInDeck2.SetActive(false);
        }
        if (deckLength < 2) {
            cardInDeck3.SetActive(false);
        }
        if (deckLength < 1) {
            cardInDeck4.SetActive(false);
        }
    }

    IEnumerator ShuffleAnimation() {
        yield return new WaitForSeconds(1f);
        clones = GameObject.FindGameObjectsWithTag("Clone");

        foreach (GameObject clone in clones) {
            Destroy(clone);
        }
    }

    public void Shuffle() {
        for (int i = 0; i < deckLength; i++) {
            deckContainer[0] = deck[i];
            int randomIndex = Random.Range(i, deckLength);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = deckContainer[0];
        }

        GameObject cardCreation = Instantiate(cardBack, transform.position, transform.rotation);
        cardCreation.transform.parent = gameObject.transform;
        StartCoroutine(ShuffleAnimation());
    }
}
