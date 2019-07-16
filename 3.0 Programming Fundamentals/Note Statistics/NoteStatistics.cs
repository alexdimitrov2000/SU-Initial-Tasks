using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Statistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            string musicalNoteRepresentation = string.Empty;
            string notes = string.Empty;
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double naturalsSum = 0.0;
            double sharpSum = 0.0;

            for (int i = 0; i < frequencies.Count; i++)
            {
                if (frequencies[i] == 261.63)
                {
                    musicalNoteRepresentation = "C";
                    naturalsSum += frequencies[i];
                }
                else if (frequencies[i] == 277.18)
                {
                    musicalNoteRepresentation = "C#";
                    sharpSum += frequencies[i];
                }
                else if (frequencies[i] == 293.66)
                {
                    musicalNoteRepresentation = "D";
                    naturalsSum += frequencies[i];
                }
                else if (frequencies[i] == 311.13)
                {
                    musicalNoteRepresentation = "D#";
                    sharpSum += frequencies[i];
                }
                else if (frequencies[i] == 329.63)
                {
                    musicalNoteRepresentation = "E";
                    naturalsSum += frequencies[i];
                }
                else if (frequencies[i] == 349.23)
                {
                    musicalNoteRepresentation = "F";
                    naturalsSum += frequencies[i];
                }
                else if (frequencies[i] == 369.99)
                {
                    musicalNoteRepresentation = "F#";
                    sharpSum += frequencies[i];
                }
                else if (frequencies[i] == 392.00)
                {
                    musicalNoteRepresentation = "G";
                    naturalsSum += frequencies[i];
                }
                else if (frequencies[i] == 415.30)
                {
                    musicalNoteRepresentation = "G#";
                    sharpSum += frequencies[i];
                }
                else if (frequencies[i] == 440.00)
                {
                    musicalNoteRepresentation = "A";
                    naturalsSum += frequencies[i];
                }
                else if (frequencies[i] == 466.16)
                {
                    musicalNoteRepresentation = "A#";
                    sharpSum += frequencies[i];
                }
                else if (frequencies[i] == 493.88)
                {
                    musicalNoteRepresentation = "B";
                    naturalsSum += frequencies[i];
                }

                notes += $"{musicalNoteRepresentation} ";

                List<char> noteRepresentation = new List<char>(musicalNoteRepresentation);
                
                if (noteRepresentation.Count == 2)
                {
                    sharps.Add(string.Join(", ", musicalNoteRepresentation));

                    noteRepresentation.RemoveAt(1);
                }
                else if (noteRepresentation.Count == 1)
                {
                    naturals.Add(string.Join(", ", noteRepresentation));
                }
            }

            if (naturalsSum == 0.0)
            {
                naturalsSum = Math.Round(naturalsSum, 0);
            }
            if (sharpSum == 0.0)
            {
                sharpSum = Math.Round(sharpSum, 0);
            }

            Console.WriteLine($"Notes: {notes}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            if (naturalsSum == 0.0)
            {
                Console.WriteLine($"Naturals sum: {naturalsSum:f0}");
            }
            else
            {
                Console.WriteLine($"Naturals sum: {naturalsSum:f2}");
            }
            if (sharpSum == 0.0)
            {
                Console.WriteLine($"Sharps sum: {sharpSum:f0}");
            }
            else
            {
                Console.WriteLine($"Sharps sum: {sharpSum:f2}");
            }
        }
    }
}
