/*
* Name: Rachel Maurer 
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
using System.ComponentModel;

Random rng = new Random();
/* part 1*/
Console.Write(" Full name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim(); 

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string badgeName = fullName.ToUpper();
string Username = (firstName.Substring(0, 1) + lastName).ToLower();
string Initials =  (firstName.Substring(0, 1) +"."+ lastName.Substring(0, 1)+".").ToUpper();
Console.WriteLine( " Name on Badge:" + badgeName);
Console.WriteLine( " Username: " + Username);
Console.WriteLine( " Initials: " + Initials);
Console.WriteLine( " Letters in last name: " + lastName.Length);
/* part 2*/


int studentID = rng.Next (100000, 1000000);
int locker = rng.Next (1, 501);
Console.WriteLine("student ID: " + studentID);
Console.WriteLine("Locker:" + locker);


/* part 3 */
Console.Write("Dorm x: ");
double dormX = Convert.ToDouble(Console.ReadLine());
Console.Write("Dorm y: ");
double dormY = Convert.ToDouble(Console.ReadLine());
Console.Write("class x: ");
double classX = Convert.ToDouble(Console.ReadLine());
Console.Write("class y: ");
double classY = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));
distance = Math.Round(distance, 1);
Console.WriteLine(" Distance: " + distance  + " feet");
Console.Write("Walking speed in feet per second: ");

double walkingSpeed = Convert.ToDouble(Console.ReadLine());
double timeInSeconds = distance / walkingSpeed;
int wholeSeconds = (int) Math.Floor( timeInSeconds);
double walkSeconds = distance / walkingSpeed;
int totalSeconds = Convert.ToInt32(walkSeconds);
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;
Console.WriteLine("Walk time: " + minutes + " minutes" + seconds + " seconds");

/* part 4 */
int checkDigit = studentID % 9;
Console.WriteLine("===================================");
Console.WriteLine("      ETSU STUDENT BADGE");
Console.WriteLine("===================================");
Console.WriteLine("NAME" .PadRight(10) + badgeName);
Console.WriteLine("USERNAME" .PadRight(10) + Username);
Console.WriteLine( "LOCKER" .PadRight(10) + locker);
Console.WriteLine( "WALK" .PadRight(10) + minutes + "minutes" + seconds + "seconds");
Console.WriteLine("=====================================");
