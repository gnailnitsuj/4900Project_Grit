using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public float damage;
    private float saveDmg;
    public PlayerMovement block;
    
    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")) {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.TakeDamage(damage);
            block.Collect();
        }


        else if (other.CompareTag("Block")) {
            damage = damage/2;
            block.Collect();
            Debug.Log("reduced");
        }

        else {
            damage = saveDmg;
        }
    }

    void Start() {
        saveDmg = damage;
        block = GetComponent<PlayerMovement>();
    }
}
