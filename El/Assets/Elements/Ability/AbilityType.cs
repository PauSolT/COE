using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityType
{
    public class DamageType
    {
        protected float damage;

        public void SetDamage(float dmg) { damage = dmg; }
        public float GetDamage() { return damage; }

        public void DoDamage(ref float health) { health -= damage; }
    }

    public class DamageXTimesType
    {
        protected float damage;
        protected int times;

        protected float secondsBetweenDamage;

        public void SetDamage(float dmg) { damage = dmg; }
        public void SetTimes(int times) { this.times = times; }
        public void SetSeconds(float seconds) { secondsBetweenDamage = seconds; }
        public float GetDamage() { return damage; }

        private void DoDamage(ref float health) { health -= damage; }
        public IEnumerator DoDamageXTimes(float health) {
            for (int i = 0; i < times; i++) {
                DoDamage(ref health);
                yield return new WaitForSeconds(secondsBetweenDamage);
            }
        }
    }

    public class HealType
    {
        protected float heal;
        public void SetHeal(float heal) { this.heal = heal; }
        public float GetHealth() { return heal; }

        public void DoHeal(ref float health) { health += heal; }
    }
}
