using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public float damage = 5;
    
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")) {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.TakeDamage(damage);
        }

    }
}
