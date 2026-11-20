/*
Name: Gabriela Malaka
Date: 11/12/2026
Assignment: SDC320 LAB PROJECT
Description: this is the main program file for the Rolodex/Contact
Management application. This file contains the main program logic
for adding, updating, removing, and displaying contacts.*/
//DISPLAY MENU AND GET USER CHOICE
Menu menu = new Menu();

bool running = true;
while (running)
{
    menu.DisplayMenu();
    int choice = menu.GetUserChoice();
    switch (choice)
    { //SWITCH CASE START
    //THESE ARE PLACEHOLDERS FOR THE TIME BEING
    //I WILL ADD THE CORRECT LOGIC FOR EACH MENU OPTION IN THE COMING WEEKS
        case 1:
            Console.WriteLine("You selected to add a new contact.");
            break;
        case 2:
            Console.WriteLine("You selected to remove an existing contact.");
            break;
        case 3:
            Console.WriteLine("You selected to update an existing contact.");
            break;
        case 4: // POLYMORPHISM DEMONSTRATION HERE: Storing different derived types in a single interface collection
            Console.WriteLine("You selected to display contacts.");
            List<IDisplayable> rolodexRecords = new List<IDisplayable>();
            {
                // ADDING SAMPLE CONTACTS TO THE ROLodex RECORDS LIST
                rolodexRecords.Add(new Contact("John", "Doe", "john.doe@example.com", "123-456-7890", new Address("123 Main St", "Cityville", "ST", "12345")));
                rolodexRecords.Add(new Contact("Jane", "Smith", "jane.smith@example.com", "987-654-3210", new Address("456 Elm St", "Townsville", "ST", "67890")));
            } 
            // POLYMORPHISM IN ACTION: Calls the appropriate overridden DisplayContact() method at runtime
            foreach (IDisplayable record in rolodexRecords)
            {
                Console.WriteLine("--------------------------------------");
                record.DisplayContact();
            }
            break;
        case 5:
            Console.WriteLine("Exiting the application.");
            running = false; //STOP THE LOOP AND EXIT THE APPLICATION
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    } //SWITCH CASE END
}