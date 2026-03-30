using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private float maxHP;
   [SerializeField] private float currentHP;
   [SerializeField] private float maxSTAM;
   [SerializeField] public float currentSTAM;
   public PlayerHP hpBar;
   public PlayerSTAM stamBar;
   public float attack;
   
   private void Start() {
    currentHP = maxHP;
    hpBar.SetSliderMax(maxHP);
    currentSTAM = maxSTAM;
    stamBar.SetSliderMax(maxSTAM);
   }

public void dealDamage (GameObject target) {
   var atm = target.GetComponent<PlayerStats>();
   if(atm != null){
      atm.TakeDamage(attack);
   }
}

public void TakeDamage (float amount) {
   currentHP -= amount;
   hpBar.SetSlider(currentHP);
}

public void Heal (float amount) {
   currentHP += amount;
   hpBar.SetSlider(currentHP);
}

public void drainStam (float amount) {
   currentSTAM -= amount * Time.deltaTime;
   stamBar.SetSlider(currentSTAM);
}

public void gainStam (float amount) {
   currentSTAM += amount * Time.deltaTime;
   stamBar.SetSlider(currentSTAM);
}

private void Update() { 
   if (currentHP > maxHP) { //So that we don't overheal
      currentHP = maxHP;
   }

   if (currentSTAM > maxSTAM) { //So that we don't overcap stamina
      currentSTAM = maxSTAM;
   }

   if (currentSTAM < 0) { // Stam can't go into negatives
      currentSTAM = 0;
   }

   if (currentHP <= 0) { //Calls death function 
      Death();
   }
}

private void Death() { //Placeholder for death screen
   Debug.Log(". . .");
}
}