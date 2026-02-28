using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float radius = 10f;
    Transform target;
    NavMeshAgent agent;


    void Start()
    {
        target = TargetPlayer.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance  <= radius){
            agent.SetDestination(target.position);
        }
    }
}
