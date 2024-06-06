using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("Rua das hortencias 355St", "Clean waters", "RS", "9476000");
        Address receptionAddress = new Address("496 Elm St", "Texax", "THX", "75049");
        Address outdoorGatheringAddress = new Address("Rua doutor 345", "Joinville", "SC", "94712000");

        List<Event> events = new List<Event>();
        events.Add(new Lecture("HTML essentials", "Introduction to WebDev", new DateTime(2024, 6, 10), new TimeSpan(10, 0, 0), lectureAddress, "Janilson Silva", 50));
        events.Add(new Reception("Networking Meet & Greet", "Meet and greet with industry professionals", new DateTime(2024, 6, 15), new TimeSpan(18, 0, 0), receptionAddress, "rsvp@example.com"));
        events.Add(new OutdoorGathering("Camping in the Park", "Bring your own food, games and waterproof tents!", new DateTime(2024, 6, 20), new TimeSpan(12, 0, 0), outdoorGatheringAddress, "Thunderstorm"));

        Menu menu = new Menu(events);
        menu.DisplayEvents();
        menu.ChooseEvent();
    }
}
