using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Aufgaben
{
    /// <summary>
    /// Repräsentiert einen Quader mit den Maßen Breite, Höhe und Tiefe.
    /// </summary>
    public class Cubiod
    {
        private double width;
        private double height;
        private double depth;

        /// <summary>
        /// Erstellt einen neuen Quader mit der angegebenen Breite, Höhe und Tiefe.
        /// </summary>
        /// <param name="width">Die Breite des Quaders.</param>
        /// <param name="height">Die Höhe des Quaders.</param>
        /// <param name="depth">Die Tiefe des Quaders.</param>
        public Cubiod(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        /// <summary>
        /// Erstellt einen neuen Quader mit der angegebenen Breite und Höhe.
        /// Die Tiefe wird standardmäßig auf 1 gesetzt.
        /// </summary>
        /// <param name="width">Die Breite des Quaders.</param>
        /// <param name="height">Die Höhe des Quaders.</param>
        public Cubiod(double width, double height) : this(width, height, 1)
        {
        }
    }
}
