using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverScreen;
    public GameObject Zombie1;
    public GameObject Zombie2;
    public GameObject Zombie3;
    public GameObject Zombie4;
    public GameObject Zombie5;
    public GameObject Zombie6;
    public GameObject ScoreGameOverDisplay;

    private void Update()
    {
        if(Health.HealthValue == 0 || Fire.FireStrength <= 0)
        {
            Health.HealthValue = 0;
            Fire.FireStrength = 0;
            Zombie1.SetActive(false);
            Zombie2.SetActive(false);
            Zombie3.SetActive(false);
            Zombie4.SetActive(false);
            Zombie5.SetActive(false);
            Zombie6.SetActive(false);
            GameOverScreen.SetActive(true);
            ScoreGameOverDisplay.GetComponent<Text>().text = "" + Score.ScoreValue;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
