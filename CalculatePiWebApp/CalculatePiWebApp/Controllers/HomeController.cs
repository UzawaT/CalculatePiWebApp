using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatePiWebApp.Models;
using System.Numerics;

namespace CalculatePiWebApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            CalculatePiModel model = new CalculatePiModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int points) {
            //instantiate the model object
            CalculatePiModel model = new CalculatePiModel();

            //instantiate a random object
            Random random = new Random();

            //assign number of points
            model.NumberOfPoints = points;

            //set up an array of points
            model.Points = new Point[points];

            //set properties for each points
            for (int i = 0; i < points; i++) {
                model.Points[i] = new Point {
                    PointVector = new Vector2((float)random.NextDouble(), (float)random.NextDouble())
                };

                if (model.Points[i].PointVector.LengthSquared() < 1) {
                    model.Points[i].PointColor = "red";
                }      
            }

            //assign the values to calculated value, percent error, and points in range
            model.PointsInRange = model.Points.Where(n => n.PointColor == "red").Count();
            model.CalculatedValue = 4.0 * model.PointsInRange / model.NumberOfPoints;
            model.PercentError = Math.Abs(model.CalculatedValue - Math.PI) / Math.PI * 100;

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
