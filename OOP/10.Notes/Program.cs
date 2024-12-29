
using _10.Notes;

string name = Console.ReadLine();
byte octave=byte.Parse(Console.ReadLine());
uint duration=uint.Parse(Console.ReadLine());   

Note note=new Note(name, octave, duration);

Console.WriteLine(note.ToString());
