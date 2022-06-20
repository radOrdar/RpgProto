using System;
using System.Collections.Generic;
using Combat;
using Progression;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ArmamentUI : MonoBehaviour
    {
        [SerializeField] private GameObject[] weaponBorders;
        [SerializeField] private Button[] levelUpButtons;

        public static event Action<int> OnArmamentLevelUpRequest;

        private void OnEnable()
        {
            for (var i = 0; i < levelUpButtons.Length; i++)
            {
                var m = i;
                levelUpButtons[i].onClick.AddListener(() => HandleLevelUpClick(m));
            }

            ProgressionController.OnArmamentLevelUpCandidates += HandleArmamentLevelUpCandidates;
            ProgressionController.OnLevelUpPointsConsumed += HandleOnLevelUpPointsConsumed;
        }

        private void OnDisable()
        {
            ProgressionController.OnArmamentLevelUpCandidates -= HandleArmamentLevelUpCandidates;
            ProgressionController.OnLevelUpPointsConsumed -= HandleOnLevelUpPointsConsumed;
        }

        private void HandleOnLevelUpPointsConsumed()
        {
            foreach (var levelUpButton in levelUpButtons) levelUpButton.gameObject.SetActive(false);
        }

        private void HandleArmamentLevelUpCandidates(List<int> indices)
        {
            foreach (var levelUpButton in levelUpButtons) levelUpButton.gameObject.SetActive(false);
            foreach (var index in indices) levelUpButtons[index].gameObject.SetActive(true);
        }

        private void HandleLevelUpClick(int index)
        {
            OnArmamentLevelUpRequest?.Invoke(index);
        }

        public void HandleWeaponChanged(int index)
        {
            foreach (var border in weaponBorders) border.SetActive(false);

            weaponBorders[index].SetActive(true);
        }

        public void DisableLevelUpButtons()
        {
            foreach (var levelUpButton in levelUpButtons) levelUpButton.gameObject.SetActive(false);
        }
    }
}