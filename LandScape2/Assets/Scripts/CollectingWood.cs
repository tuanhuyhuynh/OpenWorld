using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingWood : MonoBehaviour
{
    public GameObject PieceOfWood;
    private void OnTriggerEnter(Collider other)
    {
        Score.ScoreValue += 100;
        Wood.HoldingWood += 1;
        PieceOfWood.SetActive(false);
    }
}
