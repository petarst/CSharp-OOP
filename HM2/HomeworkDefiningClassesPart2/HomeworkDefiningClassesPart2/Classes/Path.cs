
namespace HomeworkDefiningClassesPart2.Classes
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> listOfPoints;

        public Path()
        {
            listOfPoints = new List<Point3D>();
        }

        public List <Point3D> ListOfPoints 
        {
            get { return listOfPoints; }
        }

        public void Add(Point3D point)
        {
            listOfPoints.Add(point);
        }
    }
}
