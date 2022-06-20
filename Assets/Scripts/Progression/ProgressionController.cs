using System;
using System.Collections.Generic;
using System.Linq;
using UI;
using UnityEngine;

namespace Progression
{
    public class ProgressionController : MonoBehaviour
    {
        public static ProgressionController Instance;

        [SerializeField] private int[] experiencesToLevelUp;

        private int currentLevel = 0;
        private float currentExperience;
        private int levelUpPoints;
        private ILevelProgressable[] progressables;

        public static event Action<List<int>> OnArmamentLevelUpCandidates;
        public static event Action OnLevelUpPointsConsumed;
        public static event Action OnLevelUp;

        private void Awake()
        {
            Instance = this;

            progressables = GetComponents<ILevelProgressable>();
            InvokeRepeating(nameof(UpgradeProgress), 0, 5);
        }

        private void OnEnable()
        {
            ArmamentUI.OnArmamentLevelUpRequest += HandleArmamentLevelUpRequest;
        }

        private void HandleArmamentLevelUpRequest(int index)
        {
            if (levelUpPoints < 1)
            {
                OnLevelUpPointsConsumed?.Invoke();
                return;
            }

            var armament = progressables.First(p => p.GetProgressionEntityType() == ProgressionEntityType.Armament);
            if (armament.TryLevelUpItem(index))
            {
                levelUpPoints--;
                if (levelUpPoints < 1) OnLevelUpPointsConsumed?.Invoke();
                else PullAndReportLevelUpCandidates();
            }
        }

        private void UpgradeProgress()
        {
            GainExperience(4);
        }

        public void GainExperience(float exp)
        {
            currentExperience += exp;
            if (currentLevel >= experiencesToLevelUp.Length - 1) return;

            //Pause Game
            //TODO handle multiple levelups at once
            if (currentExperience >= experiencesToLevelUp[currentLevel])
            {
                currentExperience -= experiencesToLevelUp[currentLevel];
                currentLevel++;
                levelUpPoints++;

                PullAndReportLevelUpCandidates();
            }
        }

        private void PullAndReportLevelUpCandidates()
        {
            foreach (var progressable in progressables)
            {
                var entityType = progressable.GetProgressionEntityType();
                var itemsCurrentAndMaxLevels = progressable.GetItemsCurrentAndMaxLevels();

                var indicesOfCandidatesToLevelUp = new List<int>();
                for (var i = 0; i < itemsCurrentAndMaxLevels.Length; i++)
                    if (itemsCurrentAndMaxLevels[i].Item1 < itemsCurrentAndMaxLevels[i].Item2)
                        indicesOfCandidatesToLevelUp.Add(i);


                switch (entityType)
                {
                    case ProgressionEntityType.Armament:
                        OnArmamentLevelUpCandidates?.Invoke(indicesOfCandidatesToLevelUp);
                        break;
                    case ProgressionEntityType.Abilities:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}