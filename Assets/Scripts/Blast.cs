using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Blast : MonoBehaviour
{
    [SerializeField] public ParticleSystem particleSystem;
    List<ParticleCollisionEvent> colEvent = new List<ParticleCollisionEvent>();

    void Update() {
        if(Input.GetKeyDown("e")) {
            particleSystem.Play();
        }
    }

    void OnParticleCollision(GameObject other) {

        int events =  particleSystem.GetCollisionEvents(other, colEvent);

        Debug.Log("hit");

        for (int i = 0; i < events; i++) {

        }
    }
}
