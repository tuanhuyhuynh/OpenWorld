using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] float stoppingDistance = 2;

    NavMeshAgent agent;

    public string hitTag;
    public float hitRate = 1f;
    public bool isHitting = false;
    //public GameObject HurtFlask;
    GameObject target;

    public bool isPlayingSound = false;
    public int genSound;
    public AudioSource[] zombieSound;
    public AudioSource PlayerHurtSound;

    public GameObject hurtFlask;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
            float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist < stoppingDistance)
            {
                StopEnemy();
            }
            else
            {
                GoToTarget();
            }
    }

    private void GoToTarget()
    {
        StartCoroutine(zombieNoise());
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
        agent.GetComponent<Animator>().Play("Z_Run_InPlace");
    }

    IEnumerator zombieNoise()
    {
        if(isPlayingSound == false)
        {
            isPlayingSound = true;
            genSound = Random.Range(0, 3);
            zombieSound[genSound].Play();
            yield return new WaitForSeconds(3);
            isPlayingSound = false;
        }
    }
    private void StopEnemy()
    {
        agent.isStopped = true;
        if ( isHitting == false )
        {
            StartCoroutine(DamageHealth());
        }
    }

    IEnumerator DamageHealth()
    {
        isHitting = true;
        if (Health.HealthValue >0)
        {
            Health.HealthValue -= 5;
        }
        else
        {
            Health.HealthValue = 0;
        }
        agent.GetComponent<Animator>().Play("Z_Attack");
        //hurtFlask.GetComponent<Animator>().Play("HurtFlaskAnim");
        PlayerHurtSound.Play(); 
        hurtFlask.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        hurtFlask.SetActive(false);
        yield return new WaitForSeconds(hitRate);
        isHitting = false;
    }
}
