using System;
class EventManagement
{
    static void Main()
    {
        FirstCheckPoint();
        string eventName = getEventName();
        string eventDate = getEventDate();
        string eventLocation = getEventLocation();
        SecondCheckPoint();
        ThirdCheckPoint();
        FourthCheckPoint();
        FinalCheckPoint();
        Console.WriteLine("Event Management System Execution Completed. Thank you for using the system!");


    }
    static void FirstCheckPoint()
    {
        Console.WriteLine("First Checkpoint: Event Management System Initialized.");
        string name = "Event Management System";
        int version = 1;
        Console.WriteLine($"Welcome to {name} Version {version}");
        Console.WriteLine("First Checkpoint: Event Management System Initialized.");

    }
    static string Eventname()
    {
        Console.WriteLine("Enter the name of the event:");
        string eventName = Console.ReadLine();
        return eventName;

    }
    static string getEventName()
    {
        string eventName = Eventname();
        Console.WriteLine($"Event Name: {eventName}");
        return eventName;


    }
    static string EventDate()
    {
        Console.WriteLine("Enter the date of the event (YYYY-MM-DD):");
        string date = Console.ReadLine();
        //Console.WriteLine("Enter the date of the event (YYYY-MM-DD):");
        DateTime eventDate;
        while (!DateTime.TryParse(date, out eventDate))
        {
            Console.WriteLine("Invalid date format. Please enter the date in YYYY-MM-DD format:");
            date = Console.ReadLine();
        }
        return date;
    }
    static string getEventDate()
    {
        string date = EventDate();
        Console.WriteLine($"Event Date: {date}");
        return date;
    }
    static string EventLocation()
    {
        Console.WriteLine("Enter the location of the event:");
        string location = Console.ReadLine();
        return location;
    }
    static string getEventLocation()
    {
        string location = EventLocation();
        Console.WriteLine($"Event Location: {location}");
        return location;
    }
    static void SecondCheckPoint()
    {
        Console.WriteLine("Second Checkpoint: Event Details Collected.");
        string eventName = getEventName();
        string eventDate = getEventDate();
        string eventLocation = getEventLocation();
        Console.WriteLine($"Event Details: Name - {eventName}, Date - {eventDate}, Location - {eventLocation}");
    }
    static void ThirdCheckPoint()
    {
        Console.WriteLine("Third Checkpoint: Event Management System Ready for Use.");
        Console.WriteLine("You can now manage your events using the provided details.");
    }
    static void FourthCheckPoint()
    {
        Console.WriteLine("Fourth Checkpoint: Event Management System Completed.");
        Console.WriteLine("Thank you for using the Event Management System. Goodbye!");




    }
    static void FinalCheckPoint()
    {
        Console.WriteLine("Final Checkpoint: Event Management System Execution Completed.");
        Console.WriteLine("All events have been processed successfully.");

    }
}
