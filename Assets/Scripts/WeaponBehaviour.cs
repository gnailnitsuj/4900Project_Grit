using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public GameObject weapon;
    public GameObject defense;

    //Weapon Hitboxes
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


    //Blocking & Riposte hitboxes
    public void EnableBlockCollider (int enableDef) {
        if (defense != null) {
            var collider = defense.GetComponent<Collider>();
            if (collider != null) {
                if (enableDef == 1) {
                    collider.enabled = true;
                    Debug.Log("blocked");
                }
                else {
                    collider.enabled = false;
                    Debug.Log("unblock");
                }
            }
        }
    }
}
