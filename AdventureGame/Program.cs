Console.WriteLine("Welcome to the haunted house!");
Console.WriteLine("Your family bought a old scary house to start a new life");
Console.WriteLine("Now that you and your family own this new home, you decide to explore a little");
Console.WriteLine("The house is dated, creepy, and falling apart! You walk in the front door.");
Console.WriteLine("Do you want to enter the living room or the kitchen?");

//Promt the user for a choice
Console.Write("> ");
string roomChoice = Console.ReadLine();

/// Ask player what room they want to explore
if(roomChoice == "living room")
{
    Console.WriteLine("You chose to go into the living room.");
    Console.WriteLine("As you walk in you see a ghost like figure in the corner of the room.");
    Console.WriteLine("Do you want to approach the ghost like figure?");

    //Promt user for a choice
    Console.Write("> ");
    string ghostFigureChoice = Console.ReadLine(); 

    if(ghostFigureChoice == "yes")
    {
        Console.WriteLine("You attempt to touch the ghost, but the ghost screams and attacks you!");
        Console.WriteLine("You died!");
    }
    else if(ghostFigureChoice == "no")
    {
        Console.WriteLine("you decided to not come in contact with the ghost.");
        Console.WriteLine("You turned around and left the house safley.");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer yes or no. ");
    }
}
else if(roomChoice == "kitchen")
{
    Console.WriteLine("You chose to go into the kitchen. ");
    Console.WriteLine("As you walk in you see a bloody knife on the counter! ");
    Console.WriteLine("Do you want to check out the knife? ");

    // Promt the user for a choice
    Console.Write("> ");
    string knifeChoice = Console.ReadLine();

    if(knifeChoice == "yes")
    {
        Console.WriteLine("You interact with the knife and see two fingers! ");
        Console.WriteLine("The ghost pops up and attacks you");
        Console.WriteLine("Your journey is over!");
    }
    else if(knifeChoice == "no")
    {
        Console.WriteLine("You decide no to interact with the knife. ");
        Console.WriteLine("As you turn to leave, You hear the ghost scream");
        Console.WriteLine("The ghost lunges at you, knocking you unconcious");
        Console.WriteLine("You wake up in you bed! It was all a dream!");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please answer yes or no. ");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please answer living room or kitchen. ");

}