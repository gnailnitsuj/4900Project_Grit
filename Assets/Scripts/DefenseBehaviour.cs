using UnityEngine;

public class DefenseBehavior : MonoBehaviour
{
    BoxCollider blockCollider;
    public float damageReduction;

    private void Awake() {
        blockCollider = GetComponent<BoxCollider>();
    }
}
