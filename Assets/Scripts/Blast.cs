using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Blast : MonoBehaviour
{
    [SerializeField] public ParticleSystem particleSystem;
    [SerializeField] public PlayerStats playerStats;
    List<ParticleCollisionEvent> colEvent = new List<ParticleCollisionEvent>();
    public float blastDamage = 40f;

    void Update() {
        if(Input.GetKeyDown("e") && playerStats.currentMP > 1) {
            particleSystem.Play();
        }
    }

    void OnParticleCollision(GameObject other) {

        int events =  particleSystem.GetCollisionEvents(other, colEvent);

        for (int i = 0; i < events; i++) {
            
        }

        if(other.TryGetComponent(out EnemyStats enemy)) {
            enemy.TakeDamage(blastDamage);
            Debug.Log("hit");
        }
    }
}
