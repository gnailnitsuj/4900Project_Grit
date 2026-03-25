using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    [SerializeField] public float damage;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Enemy")) {
            EnemyStats enemy = other.GetComponent<EnemyStats>();
            enemy.TakeDamage(damage);
        }
    }
}
