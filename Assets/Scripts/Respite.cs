using UnityEngine;

public class Respite : MonoBehaviour, IIteractable
{
    [SerializeField] public PlayerStats player;
    public int healAmt = 1;
    public int healTime = 100;
    
    public string GetDescription() {
        return "'L' to Rest - Depart";
    }

    public void Interact() {
        if (player.currentHP < player.maxHP) {
        player.HealOverTime(healAmt, healTime);
        Debug.Log("healed");
        }
    }
}
