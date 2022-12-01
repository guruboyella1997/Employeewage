// See https://aka.ms/new-console-template for more information
int fullTime = 1,  Emp_Rate_Per_Hoyr = 20,empHrs = 0,empwage = 0; 
Random ranobj = new Random();
int checkpresent = ranobj.Next(0, 2);
Console.WriteLine("Random number=" + checkpresent);
if (checkpresent == fullTime)
{
    empHrs = 8;
    Console.WriteLine("Employee is present");
}
else
{
    empwage = 0;
    Console.WriteLine("Employee is absent");
}
empwage = empHrs * Emp_Rate_Per_Hoyr;
Console.WriteLine("Employee wage:" + empwage);

