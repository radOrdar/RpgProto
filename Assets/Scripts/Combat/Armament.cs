using System;
using System.Collections.Generic;
using Progression;
using UI;
using UnityEngine;

namespace Combat
{
    public class Armament : MonoBehaviour, ILevelProgressable
    {
        [SerializeField] private WeaponSO[] weaponsTemplates;
        [SerializeField] private Transform shootPoint;

        private List<WeaponSO> weapons = new List<WeaponSO>();
        private ArmamentUI armamentUI;
        private int currentWeaponIndex;

        private void Awake()
        {
            foreach (var weaponSo in weaponsTemplates) weapons.Add(Instantiate(weaponSo));
        }

        private void Start()
        {
            armamentUI = FindObjectOfType<ArmamentUI>();
            currentWeaponIndex = 0;
            armamentUI.HandleWeaponChanged(currentWeaponIndex);
        }

        public void MouseScroll(int delta)
        {
            var newIndex = currentWeaponIndex + delta;
            if (newIndex > weapons.Count - 1) newIndex = 0;
            if (newIndex < 0) newIndex = weapons.Count - 1;
            if (newIndex == currentWeaponIndex) return;

            currentWeaponIndex = newIndex;
            armamentUI.HandleWeaponChanged(currentWeaponIndex);
        }

        public void KeyPressed(int key)
        {
            key--;
            if (key < 0 || key > weapons.Count - 1) return;
            if (key == currentWeaponIndex) return;

            currentWeaponIndex = key;
            armamentUI.HandleWeaponChanged(currentWeaponIndex);
        }

        public void UseWeapon()
        {
            weapons[currentWeaponIndex].Shoot(shootPoint.position, (shootPoint.position - transform.position).normalized);
        }
        
        public bool TryLevelUpItem(int itemIndex)
        {
            return weapons[itemIndex].TryLevelUp();
        }

        public (int, int)[] GetItemsCurrentAndMaxLevels()
        {
            var itemsWithCurrentAndMaxLevels = new (int, int)[weapons.Count];
            for (var i = 0; i < weapons.Count; i++) itemsWithCurrentAndMaxLevels[i] = (weapons[i].CurrentLevel, weapons[i].MaxLevel);

            return itemsWithCurrentAndMaxLevels;
        }

        public ProgressionEntityType GetProgressionEntityType()
        {
            return ProgressionEntityType.Armament;
        }
    }
}