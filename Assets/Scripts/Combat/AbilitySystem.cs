using Progression;
using UnityEngine;

namespace Combat
{
    public class AbilitySystem : MonoBehaviour, ILevelProgressable
    {
        public bool TryLevelUpItem(int itemIndex)
        {
            throw new System.NotImplementedException();
        }

        public (int, int)[] GetItemsCurrentAndMaxLevels()
        {
            throw new System.NotImplementedException();
        }

        public ProgressionEntityType GetProgressionEntityType()
        {
            throw new System.NotImplementedException();
        }
    }
}