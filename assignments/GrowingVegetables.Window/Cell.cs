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
        Growing,
        PlantingShoots,
        Immature,
        Mature,
        Overgrown
    }

    internal class Game
    {
        // Factory to create game/simulation instance.
        public static Game Create() => new Game();

        // Global reference to the currently running game/simulation instance.
        private static readonly object _root = new object();
        private static Game current = null;
        public static Game Current
        {
            get
            {
                lock(_root)
                {
                    if(current == null)
                    {
                        lock (_root)
                        {
                            current = Create();
                        }
                    }
                }

                return current;
            }
        }

        public int Money { get; private set; }
        public event EventHandler<int> OnMoneyValueChanged;

        public Game()
        {
            // Game starting money
            Money = 10;
        }

        public bool TakeMoney(int amount)
        {

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
        public Cell()
        {
            Status = CellStatus.Empty;
        }

        public CellStatus Status { get; private set; }

        public void Plant()
        {
            Game.Current.TakeMoney(2);
            Status = CellStatus.Growing;
        }

        public void Grow()
        {
            Status++;
        }

        public void Harvest()
        {
            
            switch (Status)
            {
                case CellStatus.Growing:
                case CellStatus.PlantingShoots:
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
                case CellStatus.Growing:
                    return Color.Black;
                case CellStatus.PlantingShoots:
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
