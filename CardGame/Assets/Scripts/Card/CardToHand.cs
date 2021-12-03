using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardToHand : MonoBehaviour {
    [SerializeField] private GameObject hand;
    [SerializeField] private GameObject it;

    private void Update() {
        hand = GameObject.Find("Hand");
        it.transform.SetParent(hand.transform);
        it.transform.localScale = Vector3.one;
        it.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        it.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
