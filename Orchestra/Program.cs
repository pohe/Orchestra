// See https://aka.ms/new-console-template for more information


using Orchestra;

Console.WriteLine("Welcome to Music-World!");



Musician m1 = new Musician("Jimi Hendrix", "Guitar street 123", 10);
Musician m2 = new Musician("Freddy Mercury", "Drumsstreet 321", 15);
Musician m3 = new Musician("John Lennon", "Songstreet 656", 12);

Instrument i1 = new Instrument(123, "Tuba");
Instrument i2= new Instrument(4545, "Tværfløjte");
m1.AddInstrument(i1);
m1.AddInstrument(i2);

Console.WriteLine(m1.ToString());

Conductor c1 = new Conductor("Karajan", "Chief Conductor");

Orchestra.Orchestra orchestra = new Orchestra.Orchestra(c1, "Kaizers Orchestra", 1);
orchestra.AddMusician(m1);
orchestra.AddMusician(m2);
orchestra.AddMusician(m3);

orchestra.PrintAllMusicians();