using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Pistol;

    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    public float targetDistance;
    public int damageAmount = 15;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //NewBehaviourScript.enemyhp -= 15;
            if (isFiring == false)
            {
                StartCoroutine(FiringHandgun());
            }
        }
    }
    IEnumerator FiringHandgun()
    {
        RaycastHit theShot;
        isFiring = true;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }

        Pistol.GetComponent<Animator>().Play("PistolAnim");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        Pistol.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
