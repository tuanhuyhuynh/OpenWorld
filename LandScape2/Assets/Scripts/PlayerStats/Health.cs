using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public GameObject HealthDisplay;
    public static int HealthValue;

    // Start is called before the first frame update
    void Start()
    {
        HealthValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        HealthDisplay.GetComponent<Text>().text = "" + HealthValue;
    }
}
