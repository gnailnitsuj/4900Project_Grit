using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public float damage;
    private float saveDmg;
    [SerializeField] ParticleSystem collectPart = null;
    [SerializeField] ParticleSystem collectPartR = null;
    
    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")) {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.TakeDamage(damage);
        }


        else if (other.CompareTag("Block")) {
            damage = damage/2;
            Collect();
            Debug.Log("reduced");
        }

        else if (other.CompareTag("Riposte")) {
            damage = 0;
            CollectR();
        }

        else {
            damage = saveDmg;
        }
    }

    void Start() {
        saveDmg = damage;
    }

    void Collect() {
        collectPart.Play();
    }

    void CollectR() {
        collectPartR.Play();
    }
}
