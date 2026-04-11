using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public GameObject weapon;
    public GameObject defense;

    public void EnableWeaponCollider (int enableWep) {
        if (weapon != null) {
            var collider = weapon.GetComponent<Collider>();
            if (collider != null) {
                if (enableWep == 1) {
                    collider.enabled = true;
                }
                else {
                    collider.enabled = false;
                }
            }
        }
    }

    public void EnableBlockCollider (int enableDef) {
        if (defense != null) {
            var collider = defense.GetComponent<Collider>();
            if (collider != null) {
                if (enableDef == 1) {
                    collider.enabled = true;
                }
                else {
                    collider.enabled = false;
                }
            }
        }
    }
}
