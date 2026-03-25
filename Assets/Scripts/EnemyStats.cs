using UnityEngine;

public class EnemyStats : MonoBehaviour
{
   [SerializeField] private float maxHP;
   [SerializeField]private float currentHP;
   public float attack;
   
   private void Start() {
    currentHP = maxHP;
   }

public void dealDamage (GameObject target) {
   var atm = target.GetComponent<EnemyStats>();
   if(atm != null){
      atm.TakeDamage(attack);
   }
}

public void TakeDamage (float amount) {
   currentHP -= amount;
}

public void Heal (float amount) {
   currentHP += amount;
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
   Debug.Log("Enemy Felled.");
}
}
