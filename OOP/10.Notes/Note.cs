using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Notes
{
    public class Note
    {
        private string[] notesNames = { "A", "Bb", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        private byte[] octaves = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private string name;
        private byte octave;
        private uint duration;

        public string Name { get=>name; private set 
            {
                if (!notesNames.Contains(value))
                {
                    throw new ArgumentException("Invalid note name!");
                }
                name = value;
            } 
        }

        public byte Octave { get=>octave; set 
            {
                if (!octaves.Contains(value))
                {
                    throw new ArgumentException("Invalid octave!");
                }
                octave = value;
            } 
        }

        public  uint  Duration { get=>duration; set 
            {
                if (value > 1000)
                {
                    throw new ArgumentException("Invalid duration!");
                }
                duration = value;
            } 
        }

        public Note(string name,byte octave, uint duration)
        {
            Name = name;
            Octave = octave;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Name} {Octave} {Duration}".ToString();
        }
    }
}
