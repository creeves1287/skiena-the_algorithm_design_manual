using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheresWaldorf
{
    public class WaldorfFinder
    {
        public Dictionary<string, Location> FindWords(char[][] wordGrid, string[] words)
        {
            if (wordGrid == null) return null;
            Dictionary<string, Location> locations = new Dictionary<string, Location>();
            for (int k = 0; k < words.Length; k++)
            {
                string word = words[k];
                Dictionary<char, List<Location>> letterLocations = CreateLetterLocationsDictionary(word);
                AddLetterLocations(wordGrid, letterLocations);
                ValidateWordLocations(locations, letterLocations, word);
            }
        }

        private void AddLetterLocations(char[][] wordGrid, Dictionary<char, List<Location>> letterLocations)
        {
            for (int i = 0; i < wordGrid.Length; i++)
            {
                for (int j = 0; j < wordGrid[0].Length; j++)
                {
                    char letter = char.ToLower(wordGrid[i][j]);
                    if (letterLocations.ContainsKey(letter))
                    {
                        Location location = new Location(i, j);
                        letterLocations[letter].Add(location);
                    }
                }
            }
        }

        private Dictionary<char, List<Location>> CreateLetterLocationsDictionary(string word)
        {
            Dictionary<char, List<Location>> letterLocations = new Dictionary<char, List<Location>>();
            for (int l = 0; l < word.Length; l++)
            {
                char c = word[l];
                if (!letterLocations.ContainsKey(c))
                {
                    letterLocations.Add(c, new List<Location>());
                }
            }
            return letterLocations;
        }

        private void ValidateWordLocations(Dictionary<string, Location> locations, Dictionary<char, List<Location>> letterLocationsMap, string word)
        {
            char firstLetter = word[0];
            List<Location> firstLetterLocations = letterLocationsMap[firstLetter];
            for (int j = 0; j < firstLetterLocations.Count; j++)
            {
                Location location = firstLetterLocations[j];
                CheckIfWordExists(word, firstLetter, location, letterLocationsMap);
            }
        }

        private void CheckIfWordExists(string word, char firstLetter, Location firstLetterLocation, Dictionary<char, List<Location>> letterLocationsMap)
        {
            for (int i = 1; i < word.Length; i++)
            {
                char c = word[i];
                List<Location> letterLocations = letterLocationsMap[c];
                Location prevLocation = firstLetterLocation;
                int? prevLineDistance = null;
                int? prevColumnDistance = null;
                for (int j = 0; j < letterLocations.Count; j++)
                {
                    Location location = letterLocations[i];
                    int lineDistance = location.Line - prevLocation.Line;
                    int columnDistance = location.Column - prevLocation.Column;
                    if ((lineDistance <= 1 && lineDistance >= -1) && (columnDistance <= 1 && columnDistance >= -1))
                    {
                        if (prevLineDistance != null && prevLineDistance != lineDistance)
                        {
                            continue;
                        }
                        else
                        {
                            prevLineDistance = lineDistance;
                        }
                        if (prevColumnDistance != null && prevColumnDistance != columnDistance)
                        {
                            continue;
                        }
                        else
                        {
                            prevColumnDistance = columnDistance;
                        }
                    }
                    else
                    {
                        break;
                    }
                    prevLocation = location;
                }
                if (prevLocation == )
            }
        }
    }
}
