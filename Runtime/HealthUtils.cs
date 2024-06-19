namespace Healthy
{
    public static class HealthUtils
    {
        public static (float shieldRemaining, float healthRemaining) CalculateDamageSplit(float damage, float currentShield, float currentHealth, bool shieldBleedThrough)
        {
            float shieldRemaining = currentShield;
            float healthRemaining = currentHealth;
            bool damageOnlyHitsShield = shieldRemaining >= damage;
            bool damageOnlyHitsHealth = shieldRemaining <= 0;

            if (damageOnlyHitsShield)
            {
                shieldRemaining -= damage;
            }
            else if (damageOnlyHitsHealth)
            {
                healthRemaining -= damage;
            }
            else if (shieldBleedThrough)
            {
                healthRemaining -= damage - shieldRemaining;
                shieldRemaining = 0;
            }
            else
            {
                shieldRemaining = 0;
            }

            return (shieldRemaining, healthRemaining);
        }
    }

}
