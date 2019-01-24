using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculatePiWebApp.Models {
    public class CalculatePiModel {
        //properties
        public int NumberOfPoints { get; set; }
        public int PointsInRange { get; set; }
        public double CalculatedValue { get; set; }
        public double PercentError { get; set; }
        public Point[] Points { get; set; }
        public Chart Chart { get; set; }

        //constructor
        public CalculatePiModel() {
            NumberOfPoints = 0;
            PointsInRange = 0;
            CalculatedValue = 0;
            PercentError = 0;
            Points = new Point[NumberOfPoints];
            Chart = new Chart(200, 200, 1);
        }
    }

    public class Point {
        //properties
        public Vector2 PointVector { get; set; }
        public string PointColor { get; set; }

        //constructor
        public Point() {
            PointVector = new Vector2(0, 0);
            PointColor = "blue";
        }
    }

    public class Chart {
        //properties
        public int Width { get; set; }
        public int Height { get; set; }
        public int PointSize { get; set; }

        //constructor
        public Chart(int width, int height, int size) {
            Width = width;
            Height = height;
            PointSize = size;
        }
    }
}
