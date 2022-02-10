// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Farewell, World!");
countCentury();
int countCentury()
{
	ulong years, days, hours, minutes, seconds, milliseconds, nanoseconds, centuries;
	Console.WriteLine($" input century ");

	centuries = (ulong) Convert.ToInt32(ReadLine());

	years = centuries * 100;
	
	days = centuries * 36524;
	hours = days * 24;
	minutes = hours * 60;
	seconds = minutes * 60;
	milliseconds = seconds * 1000;
	nanoseconds = milliseconds * 1000000;

	string timedetail = String.Format("{0} centuries = {1} years = {2} days ={3} hours= {4} minutes = {5} seconds= {6} miliseconds = {7} nanoseconds ",
centuries,years,days,hours,minutes,seconds,milliseconds,nanoseconds);

	WriteLine(timedetail);
	return 0;
}
