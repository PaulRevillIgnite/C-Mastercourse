

// Build a Console Guest Book.
// Ask the user for their name and how many are in their party.
// Keep track of how many people are at the party.
// At the end, print out the guest list and the total number of guests.

using GuestBookHomeworkMethods;
using System.Xml.Linq;

Methods.Greeting();

Dictionary<string, int> guestBook = Methods.CreateGuestbook();

Methods.PrintGuesbook(guestBook);

Methods.DisplayTotalGuests(guestBook);