using System;
using UnityEngine;

namespace Healthy
{
    [Serializable]
    public class HealthTraits
    {
        [SerializeField]
        private float maxHealth;
        public float MaxHealth { get => maxHealth; private set => maxHealth = value; }

        [SerializeField]
        private float maxShield;
        public float MaxShield { get => maxShield; private set => maxShield = value; }

        [SerializeField]
        private RegenTrigger regenTrigger;
        public RegenTrigger RegenTrigger { get => regenTrigger; private set => regenTrigger = value; }

        [SerializeField]
        private float healthRegenRate;
        public float HealthRegenRate { get => healthRegenRate; private set => healthRegenRate = value; }

        [SerializeField]
        private float shieldRegenRate;
        public float ShieldRegenRate { get => shieldRegenRate; private set => shieldRegenRate = value; }

        [SerializeField]
        private float healthRegenDelay;
        public float HealthRegenDelay { get => healthRegenDelay; private set => healthRegenDelay = value; }

        [SerializeField]
        private float shieldRegenDelay;
        public float ShieldRegenDelay { get => shieldRegenDelay; private set => shieldRegenDelay = value; }

        [SerializeField]
        private bool shieldBleedThrough;
        public bool ShieldBleedThrough { get => shieldBleedThrough; private set => shieldBleedThrough = value; }

        public HealthTraits()
        {
            this.MaxHealth = 100;
            this.MaxShield = 100;
            this.RegenTrigger = RegenTrigger.HealthThenShield;
            this.HealthRegenRate = 10;
            this.ShieldRegenRate = 20;
            this.HealthRegenDelay = 1;
            this.ShieldRegenDelay = 2;
            this.ShieldBleedThrough = true;
        }

        public HealthTraits(float maxHealth, float maxShield, RegenTrigger regenTrigger, float healthRegenRate, float shieldRegenRate, float healthRegenDelay, float shieldRegenDelay, bool shieldBleedThrough)
        {
            this.MaxHealth = maxHealth;
            this.MaxShield = maxShield;
            this.RegenTrigger = regenTrigger;
            this.HealthRegenRate = healthRegenRate;
            this.ShieldRegenRate = shieldRegenRate;
            this.HealthRegenDelay = healthRegenDelay;
            this.ShieldRegenDelay = shieldRegenDelay;
            this.ShieldBleedThrough = shieldBleedThrough;
        }
    }
}