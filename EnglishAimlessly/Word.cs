using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly
{
    public class Word
    {
        public Word()
        {
            Description = string.Empty;
        }
        public Word(string name, WordType type, string equivalent, string description, int practiced, bool important, string group)
        {
            Name = name;
            Type = type;
            Equivalent = equivalent;
            Description = description;
            Practiced = practiced;
            Important = important;
            Group = group;
        }
        public Word(int id, string name, WordType type, string equivalent, string description, int practiced, bool important, string group) : this(name, type, equivalent, description, practiced, important, group)
        {
            Id = id;
        }
        public Word(Word word)
        {
            Name = word.Name;
            Type = word.Type;
            Equivalent = word.Equivalent;
            Description = word.Description;
            Practiced = word.Practiced;
            Important = word.Important;
            Group = word.Group;
        }

        public enum WordType
        {
            adj, verb, noun, adverb, idiom, proverb
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public WordType Type { get; set; }
        public string Equivalent { get; set; }
        public string Description { get; set; }
        public int Practiced { get; set; }
        public bool Important { get; set; }
        public string Group { get; set; }

        public static WordType ToWordType(string type)
        {
            if(type == "adj")
            {
                return WordType.adj;
            }
            else if (type == "verb")
            {
                return WordType.verb;
            }
            else if(type == "adverb")
            {
                return WordType.adverb;
            }
            else if(type == "noun")
            {
                return WordType.noun;
            }
            else if (type == "idiom")
            {
                return WordType.idiom;
            }
            else if (type == "proverb")
            {
                return WordType.proverb;
            }
            else
            {
                return WordType.noun;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1}\nEquivalent: {2}\nDescription: {3}\nDifficulty: {4}\nPracticed: {5}", Name, Type.ToString(), 
                Equivalent, Description, Practiced.ToString());
        }
    }
}
