// See https://aka.ms/new-console-template for more information
int fullTime = 1;
Random ranobj = new Random();
int checkpresent = ranobj.Next(0, 2);
Console.WriteLine("Random number=" + checkpresent);
if (checkpresent == fullTime)
{
    Console.WriteLine("Employee is present");
}
else
{
    Console.WriteLine("Employee is absent");
}

