using Geo_library;
double[] data1 = {0,0,0};
double[] data2 = { -1, 5, 6 };
double[] data3 = { 4, 3, 5 }; //прямоугольный s=6
double[] data4 = { 85, 84, 13 }; //прямоугольный
double[] data5 = { 6, 5, 5 }; //равнобедренный s=12
double[] data6 = { 6, 4 };
double[] data7 = { };

Geometry shape = new Geometry();
Console.WriteLine((shape.area(1, data1)).ToString()+" "+ shape.info);
Console.WriteLine((shape.area(1, data2)).ToString() + " " + shape.info);
Console.WriteLine((shape.area(1, data3)).ToString() + " " + shape.info);
Console.WriteLine((shape.area(1, data4)).ToString() + " " + shape.info);
Console.WriteLine((shape.area(1, data5)).ToString() + " " + shape.info);
Console.WriteLine((shape.area(1, data6)).ToString() + " " + shape.info);
Console.WriteLine((shape.area(1, data7)).ToString() + " " + shape.info);

Console.WriteLine($"R= {data1[0]}  " + (shape.area(0, data1)).ToString() + " " + shape.info);
Console.WriteLine($"R= {data2[0]}  " + (shape.area(0, data2)).ToString() + " " + shape.info);
Console.WriteLine($"R= {data3[0]}  " + (shape.area(0, data3)).ToString() + " " + shape.info);
Console.WriteLine($"R= {data7}  " + (shape.area(0, data7)).ToString() + " " + shape.info);
Console.Read();