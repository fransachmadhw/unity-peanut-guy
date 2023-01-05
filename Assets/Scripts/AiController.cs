using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    public float lookRadius = 10f;
    private Transform Player;
    public GameObject player;
    public int MoveSpeed = 3;
    public float MaxDist = 1.5f;
    public float MinDist = 1f;
    Animator animator, Panimator;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Player = player.transform;
        Panimator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position + new Vector3(0f, 1.5f, 0f), (transform.forward - transform.up).normalized);
        RaycastHit hitData;
        Debug.DrawRay(ray.origin, ray.direction * 3);

        float distance = Vector3.Distance(Player.position, transform.position);

        if (distance <= lookRadius)
        {
            transform.LookAt(Player);
            
            if (Physics.Raycast(ray, out hitData, 3, layerMask, QueryTriggerInteraction.Ignore))
            {
                animator.SetBool("IsPatrolling", true);

                if (Vector3.Distance(transform.position, Player.position) >= MinDist)
                {
                    transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                    if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                    {
                        //Here Call any function U want Like Shoot at here or something
                        animator.SetBool("isAttack", true);
                        Panimator.SetBool("Dead", true);
                    }
                    else
                    {
                        animator.SetBool("isAttack", false);
                        Panimator.SetBool("Dead", false);
                    }
                }
            }
            else
            {
                animator.SetBool("IsPatrolling", false);
            }
        }
        else
        {
            animator.SetBool("IsPatrolling", false);
        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
        Gizmos.DrawWireSphere(transform.position, MaxDist);
        //Gizmos.DrawRay(transform.position, (transform.forward-transform.up).normalized * 10);
    }

    void kalah()
    {
        //script kalah
    }
}
