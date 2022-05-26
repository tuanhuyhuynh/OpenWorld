using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    public static int enemyhp;
    private void Start()
    {
        enemyhp = 100;
    }

    void DamageEnemy (int damageAmount)
    {
        enemyhp -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhp == 0)
            cube.SetActive(false);
    }
}
