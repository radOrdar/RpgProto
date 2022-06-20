namespace Progression
{
    public interface ILevelProgressable
    {
        bool TryLevelUpItem(int itemIndex);

        (int, int)[] GetItemsCurrentAndMaxLevels();

        ProgressionEntityType GetProgressionEntityType();
    }
}