using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] private float maxHP;
   [SerializeField] private float currentHP;
   [SerializeField] private float maxSTAM;
   [SerializeField] public float currentSTAM;
   public PlayerHP hpBar;
   public PlayerSTAM stamBar;
   public float attack;
   public float stamRegen;
   private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
   private Coroutine stamRate;
   
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
   currentSTAM -= amount;
   stamBar.SetSlider(currentSTAM);
   if (stamRate != null) StopCoroutine(stamRate);
   stamRate = StartCoroutine(gainStam());
}

private IEnumerator gainStam () {
   yield return new WaitForSeconds(2f);
        while(currentSTAM < maxSTAM) {
            currentSTAM += maxSTAM / 100f;
            stamBar.SetSlider(currentSTAM);
            yield return regenTick;
   }
   stamRate = null;
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