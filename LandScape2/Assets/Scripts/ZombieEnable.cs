using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieEnable : MonoBehaviour
{
    public GameObject Zombie1;
    public GameObject Zombie2;
    public GameObject Zombie3;
    public GameObject Zombie4;
    public GameObject Zombie5;
    public GameObject Zombie6;
    private void Start()
    {
        Zombie1.SetActive(false);
        Zombie2.SetActive(false);
        Zombie3.SetActive(false);
        Zombie4.SetActive(false);
        Zombie5.SetActive(false);
        Zombie6.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Score.ScoreValue > 200)
        {
            Zombie1.SetActive(true);
        }
        if (Score.ScoreValue > 1000)
        {
            Zombie2.SetActive(true);
        }
        if (Score.ScoreValue > 2000)
        {
            Zombie3.SetActive(true);
        }
        if (Score.ScoreValue > 4000)
        {
            Zombie4.SetActive(true);
        }
        if (Score.ScoreValue > 6000)
        {
            Zombie5.SetActive(true);
        }
        if (Score.ScoreValue > 10000)
        {
            Zombie6.SetActive(true);
        }
    }
}
