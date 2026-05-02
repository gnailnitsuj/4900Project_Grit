using UnityEngine;

public class DefenseStats : MonoBehaviour
{
    [SerializeField] public float blockDmg = 0;

    //Enemy and block collider, reduce damage
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            PlayerStats player = other.GetComponent<PlayerStats>();
            player.TakeDamage(blockDmg); //null statement
            Debug.Log("reduced");
        }
    }
}
