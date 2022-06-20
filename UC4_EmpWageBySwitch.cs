
// Solving using Switch Case Statement
int WagePerHrs = 20;
int FullTime = 8;
int PartTime = 4;
int NoWork = 0;
Random random = new Random();
int AttenCheck = random.Next(3, 10);

switch (AttenCheck)
{
	case 8:
		Console.WriteLine("Emp is present ");
		Console.WriteLine("Total Wage : " + (WagePerHrs * FullTime));
		break;

	case 4:
		Console.WriteLine("Emp is HalfDayWork ");
		Console.WriteLine("Total Wage : " + (WagePerHrs * PartTime));
		break;

	Default:

		Console.WriteLine("Emp is Absent  ");
		Console.WriteLine("Total Wage : " + (WagePerHrs * NoWork));
		break;
}