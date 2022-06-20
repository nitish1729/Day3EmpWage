//Calculate Daily Employee Wage - Assume Wage per Hour is 20 - Assume Full Day Hour is 8

int WagePerHrs = 20;
int FullTime = 8;
int NoWork = 0;
Random ran = new Random();

int AttenCheck = ran.Next(1, 9);

if (AttenCheck == FullTime)
{
    Console.WriteLine("Emp is Present");
    Console.WriteLine("EmpWage : " + (WagePerHrs * FullTime));
}
else
{
    Console.WriteLine("Emp is Absent");
    Console.WriteLine("EmpWage : " + (WagePerHrs * NoWork));
}