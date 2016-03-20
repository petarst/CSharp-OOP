﻿
namespace HomeworkDefiningClassesPart2.Classes
{
    using System;

    public static class Point3DDistance
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
        double distance = 0.0;

        distance = Math.Sqrt(
            (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) +
            (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) +
            (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
        return distance;
        
        }
    }
}
