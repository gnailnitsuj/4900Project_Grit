using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    [SerializeField] public float damage = 20;
    [SerializeField] public float blockDmg;


    // If the tag is an Enemy and hitboxes collide, deal damage
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Enemy")) {
            EnemyStats enemy = other.GetComponent<EnemyStats>();
            enemy.TakeDamage(damage);
        }
    }

    private void OnBlockEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            EnemyDamage enemy = other.GetComponent<EnemyDamage>();
            enemy.damage = blockDmg;
        }
    }
}
