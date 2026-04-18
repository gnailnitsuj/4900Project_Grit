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


    void Start()
    {
        oppAnim = GetComponent<Animator>();
        target = TargetPlayer.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        startPoint = transform.position;
    }

    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance  <= radius){
            agent.SetDestination(target.position);
            oppAnim.SetTrigger("skeleAtk");
        } else {
            agent.SetDestination(startPoint);
        }
        if (Time.time - lastAttack < cooldown) {
                return;
            }
        lastAttack = Time.time;
    }   
}
