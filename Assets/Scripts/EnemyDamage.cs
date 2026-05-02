using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public float damage;
    private float saveDmg;
    
    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")) {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.TakeDamage(damage);
        }


        else if (other.CompareTag("Block")) {
            damage = damage/2;
            Debug.Log("reduced");
        }

        else {
            damage = saveDmg;
        }
    }

    void Start() {
        saveDmg = damage;
    }
}
