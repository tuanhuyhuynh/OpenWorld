using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    public GameObject DisplayFireStrength;
    public static float FireStrength;
    public float decreaseFire = 0.1f; 
    // Start is called before the first frame update
    void Start()
    {
        FireStrength = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        FireStrength -= decreaseFire;
        DisplayFireStrength.GetComponent<Text>().text = "" + FireStrength;
    }
}
