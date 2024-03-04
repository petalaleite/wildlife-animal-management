string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalName = "";
string animalRescureLocation = "";
string animalAdmissionDate = "";

int maxAnimals = 10;
string selectedOption = "";
string? readInput = "";

do
{
  Console.WriteLine("Welcome to Name Wildlife Conservation Program. What would you like to do?\n");
  Console.WriteLine("\t1. List all current animals information");
  Console.WriteLine("\t2. Add new animal.");
  Console.WriteLine();
  Console.WriteLine("Enter you selection number (or type Exit to exit the program)");

  readInput = Console.ReadLine();
  if (readInput != null) selectedOption = readInput.ToLower();

  switch (selectedOption)
  {
    case "1":
      Console.WriteLine("Coming soon...");
      Console.WriteLine("Press enter to continue");
      readInput = Console.ReadLine();
      break;
    case "2":
      Console.WriteLine("Coming soon...");
      Console.WriteLine("Press enter to continue");
      readInput = Console.ReadLine();
      break;
    default:
      break;
  }
} while (selectedOption != "exit");