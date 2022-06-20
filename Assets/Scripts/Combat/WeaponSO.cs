using System;
using Progression;
using UnityEngine;

namespace Combat
{
    [CreateAssetMenu(menuName = "Weapon", fileName = "Weapon")]
    public class WeaponSO : ScriptableObject
    {
        [SerializeField] private Projectile proj;
        [SerializeField] private WeaponProgression[] progressions;

        public int CurrentLevel { get; private set; }
        public int MaxLevel => progressions.Length - 1;

        public void Shoot(Vector3 pos, Vector3 dir)
        {
            var projectile = Instantiate(proj, pos, Quaternion.identity);
            projectile.Init(dir, progressions[CurrentLevel].ProjSpeed, progressions[CurrentLevel].Dmg);
        }

        public bool TryLevelUp()
        {
            if (CurrentLevel == progressions.Length - 1) return false;
            CurrentLevel++;
            return true;
        }

        [Serializable]
        private struct WeaponProgression
        {
            [SerializeField] private float dmg;
            [SerializeField] private float attackSpeed;
            [SerializeField] private float projSpeed;

            public float Dmg => dmg;
            public float AttackSpeed => attackSpeed;
            public float ProjSpeed => projSpeed;
        }
    }
}