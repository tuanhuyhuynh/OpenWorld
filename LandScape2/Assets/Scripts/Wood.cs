using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wood : MonoBehaviour
{
    public GameObject DisplayHoldingWood;
    public static int HoldingWood;
    // Start is called before the first frame update
    void Start()
    {
        HoldingWood = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHoldingWood.GetComponent<Text>().text = "" + HoldingWood;
    }   
}
