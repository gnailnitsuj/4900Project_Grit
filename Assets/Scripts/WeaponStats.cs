using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    [SerializeField] public float damage = 20;


    // If the tag is an Enemy and hitboxes collide, deal damage
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Enemy")) {
            EnemyStats enemy = other.GetComponent<EnemyStats>();
            enemy.TakeDamage(damage);
        }
    }
}
