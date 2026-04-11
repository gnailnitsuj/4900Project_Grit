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


    void Start()
    {
        oppAnim = GetComponent<Animator>();
        target = TargetPlayer.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance  <= radius){
            agent.SetDestination(target.position);
            oppAnim.SetTrigger("skeleAtk");
        }
        if (Time.time - lastAttack < cooldown) {
                return;
            }
        lastAttack = Time.time;
    }   
}
