using System;
using System.Threading;

namespace Beep
{
    class Music
    {
        static void Main(string[] args)
        {
            Note[] Zelda =
            {
                new Note(Tone.D, Duration.HALF),
                new Note(Tone.E, Duration.EIGHTH),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.HALF),
                new Note(Tone.E, Duration.EIGHTH),
                new Note(Tone.C, Duration.QUARTER),
            };

            Note[] Epona =
            {
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
            };

            Note[] Saria =
            {
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
            };

            Note[] Sun =
            {
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
            };

            Note[] Time =
            {
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
            };

            Note[] Storm =
            {
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
            };

            Note[] Forest =
            {
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
            };

            Note[] Fire =
            {
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
            };

            Note[] Water =
            {
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
            };

            Note[] Spirit =
            {
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
            };

            Note[] Shadow =
            {
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.A, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.B, Duration.QUARTER),
            };

            Note[] Light =
            {
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
                new Note(Tone.C, Duration.QUARTER),
                new Note(Tone.D, Duration.QUARTER),
                new Note(Tone.E, Duration.QUARTER),
            };

            while (true)
            {
                Console.Clear();
                // Play the song
                Console.WriteLine("Legend of Zelda: Ocarina of Time Music");
                Console.WriteLine("(1)  Zelda's Lullaby");
                Console.WriteLine("(2)  Epona's Song");
                Console.WriteLine("(3)  Saria's Song");
                Console.WriteLine("(4)  Sun's Song");
                Console.WriteLine("(5)  Song of Time");
                Console.WriteLine("(6)  Song of Storms");
                Console.WriteLine("(7)  Minuet of Forest");
                Console.WriteLine("(8)  Bolero of Fire");
                Console.WriteLine("(9)  Serenade of Water");
                Console.WriteLine("(10) Requiem of Spirit");
                Console.WriteLine("(11) Nocturn of Shadow");
                Console.WriteLine("(12) Prelude of Light");
                Console.WriteLine("(0)  Quit");
                Console.Write("Play song: ");
                string input = Console.ReadLine();
                int parsed, choice = 14;
                // turn into a methos with the range as an input
                if (int.TryParse(input, out parsed))
                {
                    choice = parsed;
                }
                else
                {
                    Console.WriteLine("INVALID!");
                    System.Threading.Thread.Sleep(500);
                }

                switch (choice)
                {
                    case 0:
                        Console.Write("Press any key to exit.");
                        Console.ReadKey();
                        return;
                    case 1:
                        Play(Zelda);
                        break;
                    case 2:
                        Play(Epona);
                        break;
                    case 3:
                        Play(Saria);
                        break;
                    case 4:
                        Play(Sun);
                        break;
                    case 5:
                        Play(Time);
                        break;
                    case 6:
                        Play(Storm);
                        break;
                    case 7:
                        Play(Forest);
                        break;
                    case 8:
                        Play(Fire);
                        break;
                    case 9:
                        Play(Water);
                        break;
                    case 10:
                        Play(Spirit);
                        break;
                    case 11:
                        Play(Shadow);
                        break;
                    case 12:
                        Play(Light);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        System.Threading.Thread.Sleep(500);
                        break;
                }
            }
        }

        // Play the notes in a song.
        protected static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        // Define the frequencies of notes in an octave, as well as 
        // silence (rest).
        protected enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
        }

        // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 1600,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        // Define a note as a frequency (tone) and the amount of 
        // time (duration) the note plays.
        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }
}