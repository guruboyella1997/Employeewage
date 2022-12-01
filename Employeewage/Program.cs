// See https://aka.ms/new-console-template for more information
int fullTime = 1,  partTime=2,Emp_Rate_Per_Hoyr = 20,empHrs = 0,empwage = 0; 
Random ranobj = new Random();
int checkpresent = ranobj.Next(0, 3);
Console.WriteLine("Random number=" + checkpresent);
switch (checkpresent)
{
    case 1:
        empHrs = 8;
        Console.WriteLine("Employee is present");
        break;
    case 2:
        empHrs = 4;
        Console.WriteLine("Employee is Present");
        break;
    default:
        empHrs = 0;
        Console.WriteLine("Employe is absent");
        break;
}
empwage = empHrs * Emp_Rate_Per_Hoyr;
Console.WriteLine("Employee wage:" + empwage);

