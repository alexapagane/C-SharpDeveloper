string figure = Console.ReadLine();

if(figure == "square")
{
    double lenght = double.Parse(Console.ReadLine());
    double area = lenght * lenght;
    Console.WriteLine(area);
}
else if(figure == "rectangle")
{
    double width = double.Parse(Console.ReadLine());
    double hight = double.Parse(Console.ReadLine());
    double area = width * hight;
    Console.WriteLine(area);
}
else if (figure == "circle") 
{
    double radius = double.Parse(Console.ReadLine());
    double area = radius * radius *Math.PI;
    Console.WriteLine(area);
}
else //if (figure == "triangle")
{
    double lenght = double.Parse(Console.ReadLine());
    // Console.WriteLine(lenght);
    double hight = double.Parse(Console.ReadLine());
   // Console.WriteLine(hight);
    double area = lenght * hight / 2;
    Console.WriteLine(area);

}