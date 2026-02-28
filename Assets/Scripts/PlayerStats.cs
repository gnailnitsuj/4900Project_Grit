using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private float maxHP;
   private float currentHP;
   public PlayerHP hpBar;
   
   private void Start() {
    currentHP = maxHP;
    hpBar.SetSliderMax(maxHP);
   }


public void TakeDamage (float amount) {
   currentHP -= amount;
   hpBar.SetSlider(currentHP);
}

public void Heal (float amount) {
   currentHP += amount;
   hpBar.SetSlider(currentHP);
}

private void Update() { 
   if (currentHP > maxHP) { //So that we don't overheal
      currentHP = maxHP;
   }

   if (currentHP <= 0) { //Calls death function 
      Death();
   }
}

private void Death() { //Placeholder for death screen
   Debug.Log(". . .");
}
}