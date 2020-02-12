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

    internal class Cell
    {
        public Cell()
        {
            Status = CellStatus.Empty;
        }

        public CellStatus Status { get; set; }

        public void Plant()
        {
            Status = CellStatus.Growing;
        }

        public void Harvest()
        {
            Status = CellStatus.Empty;
        }
    }

    internal static class CellExtension
    {
        public static Color GetColor(this Cell cell)
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
