// Get field size
long fieldLength = int.Parse(Console.ReadLine());

// Initailise the empty field
long[] field = new long[fieldLength];

// Ladybug places in array
int[] bugPlaces = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

// Fill the field with bugs
for (int i = 0; i < bugPlaces.Length; i++)
{
    int currentIndex = bugPlaces[i];
    // Garantee for placement in the array
    if (currentIndex >= 0 && currentIndex < field.Length)
    {
        field[currentIndex] = 1;
    }
}
// Insert a command to be read by the head of the while loop
string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    // New array with arguments 
    string[] elements = command.Split();

    // Taking the arguments in separate varaibles
    int bugIndex = int.Parse(elements[0]);
    string direction = elements[1];
    int flyLength = int.Parse(elements[2]);

    // It is out of the array, and the index is without a LadyBug
    if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
    {
        // The while loop is doing a next iteration 
        continue;
    }

    // Remove the Ladybug from its space (index) in the array
    field[bugIndex] = 0;

    if (direction == "right")
    {
        // The Ladybug is jumping to the right 
        int landIndex = bugIndex + flyLength;

        //The Ladybug has flown away
        if (landIndex > field.Length - 1)
        {
            continue;
        }

        // The landing space is checked and if there is another ladybug present 
        if (field[landIndex] == 1)
        {
            // While there is a Ladybug present do the following
            while (field[landIndex] == 1)
            {
                //Keep flying
                landIndex += flyLength;
                // Out of the array
                if (landIndex > field.Length - 1)
                {
                    break;
                    
                }
            }
        }
        // There is no Ladybug present in the current index and the flying-Ladybug can land
        if (landIndex <= field.Length - 1)
        {
            field[landIndex] = 1;
        }
    }
    else if (direction == "left")
    {
        // The Ladybug is flying left 
        int landIndex = bugIndex - flyLength;

        if (landIndex < 0)
        {
            continue;
        }

        if (field[landIndex] == 1)
        {
            while (field[landIndex] == 1)
            {
                landIndex -= flyLength;

                if (landIndex < 0)
                {
                    break;
                }
            }
        }

        if (landIndex >= 0)
        {
            field[landIndex] = 1;
        }
    }
}

Console.WriteLine(string.Join(" ", field));