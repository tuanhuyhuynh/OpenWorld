using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Displayscore;
    public static int ScoreValue;
    public int internalScore;
    // Start is called before the first frame update
    void Start()
    {
        ScoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //internalScore = ScoreValue;
        Displayscore.GetComponent<Text>().text = "" + ScoreValue;
        
    }
}
