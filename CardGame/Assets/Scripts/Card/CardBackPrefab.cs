using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBackPrefab : MonoBehaviour
{
    [SerializeField] private GameObject deck;
    [SerializeField] private GameObject it;

    private void Update() {
        deck = GameObject.Find("DeckPanel");
        it.transform.SetParent(deck.transform);
        it.transform.localScale = Vector3.one;
        it.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        it.transform.eulerAngles = new Vector3(25, 0, 0);

    }
}
