using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerStats playerStats;
    public int damage = 5;
    
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player") {
            playerStats.TakeDamage(damage);
        }

    }
}
