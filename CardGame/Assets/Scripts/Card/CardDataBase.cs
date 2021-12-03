using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake() {
        cardList.Add(new Card(0, "RAT", 0, 0, 1, "None", Resources.Load<Sprite>("Images/Rat")));
        cardList.Add(new Card(1, "PEREZ", 1, 1, 2, "None", Resources.Load<Sprite>("Images/Perez")));
        cardList.Add(new Card(2, "ELOUARDANI", 2, 5, 1, "None", Resources.Load<Sprite>("Images/Moro")));
        cardList.Add(new Card(3, "GERGIVA", 3, 1, 5, "Raton", Resources.Load<Sprite>("Images/Gergiva")));
    }
}
