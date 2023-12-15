int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());  
double percent = double.Parse(Console.ReadLine());

double volume = lenght * width * hight;
double volumeInLiters = volume * 0.001;
double volumeFinal = volumeInLiters * (1 - percent / 100);

Console.WriteLine(volumeFinal);