using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingVegetables.Window
{
    internal enum CellStatus
    {
        Empty,
        Planted,
        Green,
        Immature,
        Mature,
        Overgrown
    }

    internal class Game
    {
        // a global reference to currently running game.
        public static Game Current 
        {
            get;
            set;
        }

        public int Money { get; private set; }
        public event EventHandler<int> OnMoneyValueChanged;

        public Game()
        {
            // Game starting money
            Money = 10;

            // Set current instance as Global instance.
            Current = this;
        }

        public bool TakePlantMoney()
        {
            if (Money < 2)
            {
                return false;
            }

            Money -= 2;

            // Invoke OnMoneyValueChanged event to notify subscribers (e.g: UI) to update money text value.
            OnMoneyValueChanged?.Invoke(this, this.Money);
            return true;
        }

        public bool TakeMoney(int amount)
        {
            if (Money <= 0)
            {
                return false;
            }

            if (amount > Money)
            {
                return false;
            }

            Money -= amount;

            // Invoke OnMoneyValueChanged event to notify subscribers (e.g: UI) to update money text value.
            OnMoneyValueChanged?.Invoke(this, this.Money);
            return true;
        }

        public void AddMoney(int amount)
        {
            Money += amount;

            // Invoke OnMoneyValueChanged event to notify subscribers (e.g: UI) to update money text value.
            OnMoneyValueChanged?.Invoke(this, this.Money);
        }
    }

    internal class Cell
    {
        private int progress = 0;

        private const int prPlanted = 20;
        private const int prGreen = 100;
        private const int prImmature = 120;
        private const int prMature = 140;

        public Cell()
        {
            Status = CellStatus.Empty;
        }

        public CellStatus Status { get; private set; }

        public bool Plant()
        {
            if(!Game.Current.TakePlantMoney())
            {
                // There is not enought money to plant.
                return false;
            }

            Status = CellStatus.Planted;
            progress++;

            return true;
        }

        public void Grow()
        {
            if ((Status != CellStatus.Empty) && (Status != CellStatus.Overgrown))
            {
                progress++;
                if (progress < prPlanted) Status = CellStatus.Planted;
                else if (progress < prGreen) Status = CellStatus.Green;
                else if (progress < prImmature) Status = CellStatus.Immature;
                else if (progress < prMature) Status = CellStatus.Mature;
                else Status = CellStatus.Overgrown;
            }

        }

        public void Harvest()
        {
            
            switch (Status)
            {
                case CellStatus.Planted:
                case CellStatus.Green:
                    break; // No gain if plants harvested at these status.
                case CellStatus.Immature:
                    Game.Current.AddMoney(3);
                    break;
                case CellStatus.Mature:
                    Game.Current.AddMoney(5);
                    break;
                case CellStatus.Overgrown:
                    Game.Current.TakeMoney(1);
                    break;
            }

            progress = 0;
            Status = CellStatus.Empty;
        }
    }

    internal static class CellExtension
    {
        public static Color GetStatusColor(this Cell cell)
        {
            switch (cell.Status)
            {
                case CellStatus.Empty:
                    return Color.White;
                case CellStatus.Planted:
                    return Color.Black;
                case CellStatus.Green:
                    return Color.Green;
                case CellStatus.Immature:
                    return Color.Yellow;
                case CellStatus.Mature:
                    return Color.Red;
                case CellStatus.Overgrown:
                    return Color.Brown;
                default:
                    return Color.White;
            }
        }
    }

}
