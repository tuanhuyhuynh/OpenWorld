using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    public bool IsIncrease = false;
    // Update is called once per frame
    void Update()
    {
        if (Health.HealthValue > 0 || Fire.FireStrength > 0)
        {
            StartCoroutine(increase());
        }
    }
    IEnumerator increase()
    {
        if(IsIncrease == false)
        {
            IsIncrease = true;
            Score.ScoreValue += 5;
            yield return new WaitForSeconds(1);
            IsIncrease = false;
        }
    }
}
