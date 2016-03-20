
// Problem 1. Structure:

// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
// Implement the ToString() to enable printing a 3D point.


namespace HomeworkDefiningClassesPart2
{
    using System;
    using Classes;

    class Program
    {
        static void Main()
        {
            Point3D first = new Point3D() { X = 1, Y = 3, Z = 6 };
            Point3D second = new Point3D() { X = 3, Y = 5, Z = 8 };

            Console.WriteLine(Point3D.StartCoord);

            Console.WriteLine(first);
            Console.WriteLine(second);

            var distance = Point3DDistance.Distance(first, second);
            Console.WriteLine(distance);

            Path pathList = new Path();

            pathList.Add(first);
            pathList.Add(second);

            PathStorage.Save(pathList, @"../../PathStorage.txt");
            PathStorage.Load(@"../../PathStorage.txt");

            Console.WriteLine();

            foreach (Point3D point in PathStorage.path.ListOfPoints)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine();


            var path23 = new Path1();

            for (int i = 0; i <= 10; i++)
            {
                path23.AddPoint (new Point3D () {X = i, Y = i+5, Z = i +1});

                string pathStr = @"../../path.txt";

                PathStorage1.SavePath(path23, pathStr);

                var pathFromFIle = PathStorage1.LoadPath(@"../../path.txt");

                foreach (var loadPoint in pathFromFIle)
                {
                    Console.WriteLine(loadPoint);
                }

            }

        }
    }
}
