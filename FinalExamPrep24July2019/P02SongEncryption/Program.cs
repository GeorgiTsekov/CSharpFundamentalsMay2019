using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P02SongEncryption
{
    class Program
    {
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                var matches = Regex.Matches(input, @"^([A-Z]{1}[a-z]+[ ']*[a-z]*[ ']*[a-z]*[ ']*[a-z]*):( *[A-Z]+ *[A-Z]* *[A-Z]* *[A-Z]*)$");

                string artist = string.Empty;
                string song = string.Empty;
                StringBuilder sb = new StringBuilder();

                foreach (Match name in matches)
                {
                    artist += name.Groups[1].Value;
                }
                if (artist == string.Empty)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int count = artist.Length;

                foreach (Match name in matches)
                {
                    song += name.Groups[2].Value;
                }
                
                for (int i = 0; i < artist.Length; i++)
                {
                    if (artist[i] != ' ' && artist[i] != '\'')
                    {
                        if (artist[i] + count > 90 && artist[i] <= 90)
                        {
                            sb.Append((char)(count + artist[i] - 26));
                        }
                        else if (artist[i] + count > 122 && artist[i] <= 122)
                        {
                            sb.Append((char)(count + artist[i] - 26));
                        }
                        else
                        {
                            sb.Append((char)(artist[i] + count));
                        }
                    }
                    else
                    {
                        sb.Append(artist[i]);
                    }
                }
                sb.Append('@');
                for (int i = 0; i < song.Length; i++)
                {
                    if (song[i] != ' ')
                    {
                        if (song[i] + count > 90 && song[i] <= 90)
                        {
                            sb.Append((char)(count + song[i] - 26));
                        }                       
                        else
                        {
                            sb.Append((char)(song[i] + count));
                        }
                    }
                    else
                    {
                        sb.Append(song[i]);
                    }
                }
                Console.WriteLine($"Successful encryption: {sb}");
            }
        }
    }
}
