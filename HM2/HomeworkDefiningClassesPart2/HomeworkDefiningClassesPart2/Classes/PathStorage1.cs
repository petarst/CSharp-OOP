namespace HomeworkDefiningClassesPart2.Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Classes;

    public static class PathStorage1
    {
        public static void SavePath(Path1 path1, string filePath1)

        {
            using (var streamWr = new StreamWriter(filePath1))
            {
                foreach (var point in path1)
                {
                    streamWr.WriteLine(point);
                }
            
            }
        }

        public static Path1 LoadPath(string filePath1) 
        {
            var path = new Path1();

            using (var streamRead= new StreamReader (filePath1))
            {
                string line;

                while ((line = streamRead.ReadLine()) != null)
                {
                    Point3D point = Point3D.Parse(line);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
