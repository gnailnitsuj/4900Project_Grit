using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public GameObject weapon;

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
}
