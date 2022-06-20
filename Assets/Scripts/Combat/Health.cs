using System;
using Progression;
using UnityEngine;

namespace Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int[] healthProgressions;

        public event Action<float, float> OnHealthChanged;
        private float currentHealth;
        private int currentLevel;

        private void OnEnable()
        {
            ProgressionController.OnLevelUp += HandleOnLevelUp;
        }

        private void HandleOnLevelUp()
        {
            if (currentLevel > healthProgressions.Length - 1) return;

            var oldHealth = currentHealth;
            var currentHealthPercentage = currentHealth / healthProgressions[currentLevel];
            currentLevel++;
            currentHealth = currentHealthPercentage * healthProgressions[currentLevel];
            OnHealthChanged?.Invoke(oldHealth, currentHealth);
        }
    }
}