using UnityEngine;

namespace Healthy
{
    [CreateAssetMenu(fileName = "HealthData", menuName = "Health/HealthData", order = 1)]
    public class HealthData : ScriptableObject
    {
        [SerializeField]
        private HealthTraits traits = new HealthTraits();
        public HealthTraits Traits { get => traits; }

        public HealthData(HealthTraits traits)
        {
            this.traits = traits;
        }
    }
}