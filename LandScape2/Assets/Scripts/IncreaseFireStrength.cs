using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseFireStrength : MonoBehaviour
{
    public GameObject FireTrigger;
    public GameObject NoWoodAlert;
    //IEnumerator Check1s()
    //{
        //if(Wood.HoldingWood > 0)
        //{
        //    Fire.FireStrength = Fire.FireStrength + (100 * Wood.HoldingWood);
        //    Wood.HoldingWood -= Wood.HoldingWood; 
        //}
        //else
        //{
        //    Alert();
        //}
        //yield return new WaitForSeconds(2);
        
    //}

    //IEnumerator Alert()
    //{
    //    NoWoodAlert.SetActive(true);
    //    yield return new WaitForSeconds(1);
    //    //NoWoodAlert.SetActive(false);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (Wood.HoldingWood > 0)
        {
            Fire.FireStrength = Fire.FireStrength + (100 * Wood.HoldingWood);
            Wood.HoldingWood -= Wood.HoldingWood;
        }
        else
        {
            NoWoodAlert.SetActive(true);
            //Alert();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        NoWoodAlert.SetActive(false);
    }
}
