string word = "";
int month = 0;
int day = 0;
bool validMonth = false;
bool validDay = false;

do
{
  Console.Write("Enter your month: ");
  if (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
  {
    Console.WriteLine("Invalid Input!\n");
    validMonth = false;
  }
  else
  {
    validMonth = true;
  }
} while (!validMonth);

if (validMonth)
{
  switch (month)
  {
    case 1:
      word = "January";
      break;
    case 2:
      word = "February";
      break;
    case 3:
      word = "March";
      break;
    case 4:
      word = "April";
      break;
    case 5:
      word = "May";
      break;
    case 6:
      word = "June";
      break;
    case 7:
      word = "July";
      break;
    case 8:
      word = "August";
      break;
    case 9:
      word = "September";
      break;
    case 10:
      word = "October";
      break;
    case 11:
      word = "November";
      break;
    case 12:
      word = "December";
      break;
  }
}

do
{
    Console.Write("Enter the day: ");
    if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
    {
        Console.WriteLine("Only from 1 to 31!\n");
        validDay = false;
    }
    else
    {
        validDay = true;
    }
} while (!validDay);


Console.Write("Enter the year: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nMonth: " + word + "\nDay: " + day + "\nYear: " + year);
