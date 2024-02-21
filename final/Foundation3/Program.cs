using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("912 Hickory Ridge Drive", "Las Vegas", "NV", "89109");
        Address a2 = new Address("1914 Roosevelt Road", "Moran", "KS", "66755");
        Address a3 = new Address("4987 Pinewood Avenue", "Marquette", "MI", "49855");

        Lecture lecture = new Lecture("Modern Focus Of Criminology", "A lecture on the most prevalent topics of discussion in today's world of criminology and criminal justice.", "March 15, 2024", "2:15 PM", a1, "Tomasz Snarski", 90);
        Reception reception = new Reception("Wedding", "The wedding of Mary and James Williams.", "June 1, 2024", "5:00 PM", a2, "reservation@gmail.com");
        OutdoorGathering outdoor = new OutdoorGathering("Pet Picnic", "A picnic in the park for local pet owners.", "May 25, 2024", "12:30 PM", a3, "Sunny");

        Console.WriteLine("-------------------");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("-------------------");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine();

        Console.WriteLine("-------------------");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("-------------------");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine();

        Console.WriteLine("-------------------");
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine("-------------------");
        Console.WriteLine(outdoor.GetFullDetails());

    }
}