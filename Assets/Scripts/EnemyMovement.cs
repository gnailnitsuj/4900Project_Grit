using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public float radius = 10f;
    Transform target;
    NavMeshAgent agent;
    public Animator oppAnim;
    private float lastAttack;
    private float cooldown = 2;
    private Vector3 startPoint;
    private float resetHP = 20;
    public EnemyStats enemyStats; 


    void Start()
    {
        oppAnim = GetComponent<Animator>();
        target = TargetPlayer.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        startPoint = transform.position;
    }

    
    void Update()
    {
        // Return enemy if target is outside of radius
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance  <= radius){
            agent.SetDestination(target.position);
            oppAnim.SetTrigger("skeleAtk");
        } else { //Enemy will gradually heal whilst retreating
            agent.SetDestination(startPoint);
            enemyStats.Heal(resetHP);
        }
        if (Time.time - lastAttack < cooldown) {
                return;
            }
        lastAttack = Time.time;
    }   
}
