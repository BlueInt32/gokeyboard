using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoKeyboard.DAL
{
    public class SeedLogic
    {
        public List<Finger> Fingers { get; set; }
        public List<Key> Keys { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Chapter> Chapters { get; set; }

        readonly List<string> _lessonsShort = new List<string> { "fj", "ei", "dk", "sl", "qm", "ru", "zo", "ap", "gh", "ty", "vn", "b,", "c;", "x:", "w!" };

        public void CreateFingers()
        {
            Fingers = new List<Finger> { 
                new Finger {Code = "id",Name = "Index droit"},
                new Finger {Code = "md",Name = "Majeur droit"},
                new Finger {Code = "ad",Name = "Annulaire droit"},
                new Finger {Code = "od",Name = "Auriculaire droit"},
                new Finger {Code = "pd",Name = "Pouce droit"},
                new Finger {Code = "ig",Name = "Index gauche"},
                new Finger {Code = "mg",Name = "Majeur gauche"},
                new Finger {Code = "ag",Name = "Annulaire gauche"},
                new Finger {Code = "og",Name = "Auriculaire gauche"},
                new Finger {Code = "pg",Name = "Pouce gauche"}

            };
        }

        public void CreateKeys()
        {
            Keys = new List<Key>
                    {
                        new Key { Index = 32 , Print=" ", Token="space", LineIndex=4, LinePosition=11, Shifted=false, Fingers= GetFingers("pd").ToList() },
		                new Key { Index = 33 , Print="!", Token="exclam",       LineIndex=4, LinePosition=11, Shifted=false, Fingers= GetFingers("od").ToList()  },
		                new Key { Index = 34 , Print="\"", Token="dquote",     LineIndex=1, LinePosition=3,  Shifted=false, Fingers= GetFingers("mg|pd").ToList()   },
		                new Key { Index = 35 , Print="#", Token="sharp",       LineIndex=1, LinePosition=3,  Shifted=false, Fingers= GetFingers("mg|pd").ToList(), AltGred=true  },
		                new Key { Index = 36 , Print="$", Token="dollar",       LineIndex=2, LinePosition=12, Shifted=false, Fingers= GetFingers("od").ToList()   },
		                new Key { Index = 37 , Print="%", Token="percent",       LineIndex=3, LinePosition=11, Shifted=true , Fingers= GetFingers("od|og").ToList()  },
		                new Key { Index = 38 , Print="&", Token="esp",       LineIndex=1, LinePosition=1,  Shifted=false, Fingers= GetFingers("og").ToList()  },
		                new Key { Index = 39 , Print="'", Token="quote",       LineIndex=1, LinePosition=4,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 40 , Print="(", Token="parleft",       LineIndex=1, LinePosition=5,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 41 , Print=")", Token="parright",       LineIndex=1, LinePosition=11, Shifted=false, Fingers= GetFingers("od").ToList()  },
		                new Key { Index = 42 , Print="*", Token="star",       LineIndex=3, LinePosition=12, Shifted=false, Fingers= GetFingers("od").ToList()  },
		                new Key { Index = 43 , Print="+", Token="plus",       LineIndex=3, LinePosition=12, Shifted=true , Fingers= GetFingers("od|og").ToList()  },
		                new Key { Index = 44 , Print=",", Token="coma",       LineIndex=4, LinePosition=8,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 45 , Print="-", Token="minus",       LineIndex=1, LinePosition=6,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 46 , Print=".", Token="dot",       LineIndex=4, LinePosition=9,  Shifted=true , Fingers= GetFingers("md|og").ToList()},
		                new Key { Index = 47 , Print="/", Token="slash",       LineIndex=4, LinePosition=10, Shifted=true , Fingers= GetFingers("ad|og").ToList()},
		                new Key { Index = 48 , Print="0", Token="0",       LineIndex=1, LinePosition=10, Shifted=true , Fingers= GetFingers("od|og").ToList()},
		                new Key { Index = 49 , Print="1", Token="1",       LineIndex=1, LinePosition=1,  Shifted=true , Fingers= GetFingers("og|od").ToList()},
		                new Key { Index = 50 , Print="2", Token="2",       LineIndex=1, LinePosition=2,  Shifted=true , Fingers= GetFingers("ag|od").ToList()},
		                new Key { Index = 51 , Print="3", Token="3",       LineIndex=1, LinePosition=3,  Shifted=true , Fingers= GetFingers("mg|od").ToList()},
		                new Key { Index = 52 , Print="4", Token="4",       LineIndex=1, LinePosition=4,  Shifted=true , Fingers= GetFingers("ig|od").ToList()},
		                new Key { Index = 53 , Print="5", Token="5",       LineIndex=1, LinePosition=5,  Shifted=true , Fingers= GetFingers("ig|od").ToList()},
		                new Key { Index = 54 , Print="6", Token="6",       LineIndex=1, LinePosition=6,  Shifted=true , Fingers= GetFingers("id|og").ToList()},
		                new Key { Index = 55 , Print="7", Token="7",       LineIndex=1, LinePosition=7,  Shifted=true , Fingers= GetFingers("id|og").ToList()},
		                new Key { Index = 56 , Print="8", Token="8",       LineIndex=1, LinePosition=8,  Shifted=true , Fingers= GetFingers("md|og").ToList()},
		                new Key { Index = 57 , Print="9", Token="9",       LineIndex=1, LinePosition=9,  Shifted=true , Fingers= GetFingers("ad|og").ToList()},
		                new Key { Index = 58 , Print=":", Token="colon",       LineIndex=4, LinePosition=10, Shifted=false, Fingers= GetFingers("ad").ToList()   },
		                new Key { Index = 59 , Print=";", Token="semicolon",       LineIndex=4, LinePosition=9,  Shifted=false, Fingers= GetFingers("md").ToList()   },
		                new Key { Index = 60 , Print="<", Token="lt",       LineIndex=4, LinePosition=1,  Shifted=false, Fingers= GetFingers("og").ToList()   },
		                new Key { Index = 61 , Print="=", Token="equal",       LineIndex=1, LinePosition=12, Shifted=false, Fingers= GetFingers("od").ToList()   },
		                new Key { Index = 62 , Print=">", Token="mt",       LineIndex=4, LinePosition=1,  Shifted=true , Fingers= GetFingers("og").ToList()  },
		                new Key { Index = 63 , Print="?", Token="qm",       LineIndex=4, LinePosition=8,  Shifted=true , Fingers= GetFingers("id|og").ToList()  },
		                new Key { Index = 64 , Print="@", Token="at",       LineIndex=1, LinePosition=10, Shifted=false, Fingers= GetFingers("od|pd").ToList(), AltGred=true },
		                new Key { Index = 65 , Print="A", Token="A",       LineIndex=2, LinePosition=1,  Shifted=true , Fingers= GetFingers("og|od").ToList()   },
		                new Key { Index = 66 , Print="B", Token="B",       LineIndex=4, LinePosition=6,  Shifted=true , Fingers= GetFingers("ig|od").ToList()   },
		                new Key { Index = 67 , Print="C", Token="C",       LineIndex=4, LinePosition=4,  Shifted=true , Fingers= GetFingers("mg|od").ToList()   },
		                new Key { Index = 68 , Print="D", Token="D",       LineIndex=3, LinePosition=3,  Shifted=true , Fingers= GetFingers("mg|od").ToList()   },
		                new Key { Index = 69 , Print="E", Token="E",       LineIndex=2, LinePosition=3,  Shifted=true , Fingers= GetFingers("mg|od").ToList()   },
		                new Key { Index = 70 , Print="F", Token="F",       LineIndex=3, LinePosition=4,  Shifted=true , Fingers= GetFingers("ig|od").ToList()   },
		                new Key { Index = 71 , Print="G", Token="G",       LineIndex=3, LinePosition=5,  Shifted=true , Fingers= GetFingers("ig|od").ToList()   },
		                new Key { Index = 72 , Print="H", Token="H",       LineIndex=3, LinePosition=6,  Shifted=true , Fingers= GetFingers("id|og").ToList()   },
		                new Key { Index = 73 , Print="I", Token="I",       LineIndex=2, LinePosition=8,  Shifted=true , Fingers= GetFingers("md|og").ToList()   },
		                new Key { Index = 74 , Print="J", Token="J",       LineIndex=3, LinePosition=7,  Shifted=true , Fingers= GetFingers("id|og").ToList()   },
		                new Key { Index = 75 , Print="K", Token="K",       LineIndex=3, LinePosition=8,  Shifted=true , Fingers= GetFingers("md|og").ToList()   },
		                new Key { Index = 76 , Print="L", Token="L",       LineIndex=3, LinePosition=9,  Shifted=true , Fingers= GetFingers("ad|og").ToList()   },
		                new Key { Index = 77 , Print="M", Token="M",       LineIndex=3, LinePosition=10, Shifted=true , Fingers= GetFingers("od|og").ToList()   },
		                new Key { Index = 78 , Print="N", Token="N",       LineIndex=4, LinePosition=7,  Shifted=true , Fingers= GetFingers("id|og").ToList()   },
		                new Key { Index = 79 , Print="O", Token="O",       LineIndex=2, LinePosition=9,  Shifted=true , Fingers= GetFingers("ad|og").ToList()   },
		                new Key { Index = 80 , Print="P", Token="P",       LineIndex=2, LinePosition=10, Shifted=true , Fingers= GetFingers("od|og").ToList()   },
		                new Key { Index = 81 , Print="Q", Token="Q",       LineIndex=3, LinePosition=1,  Shifted=true , Fingers= GetFingers("og|od").ToList()   },
		                new Key { Index = 82 , Print="R", Token="R",       LineIndex=2, LinePosition=4,  Shifted=true , Fingers= GetFingers("ig|od").ToList()   },
		                new Key { Index = 83 , Print="S", Token="S",       LineIndex=3, LinePosition=2,  Shifted=true , Fingers= GetFingers("ag|od").ToList()   },
		                new Key { Index = 84 , Print="T", Token="T",       LineIndex=2, LinePosition=5,  Shifted=true , Fingers= GetFingers("ig|od").ToList()   },
		                new Key { Index = 85 , Print="U", Token="U",       LineIndex=2, LinePosition=7,  Shifted=true , Fingers= GetFingers("id|og").ToList()   },
		                new Key { Index = 86 , Print="V", Token="V",       LineIndex=4, LinePosition=5,  Shifted=true , Fingers= GetFingers("ig|od").ToList()   },
		                new Key { Index = 87 , Print="W", Token="W",       LineIndex=4, LinePosition=2,  Shifted=true , Fingers= GetFingers("og|od").ToList()   },
		                new Key { Index = 88 , Print="X", Token="X",       LineIndex=4, LinePosition=3,  Shifted=true , Fingers= GetFingers("ag|od").ToList()   },
		                new Key { Index = 89 , Print="Y", Token="Y",       LineIndex=2, LinePosition=6,  Shifted=true , Fingers= GetFingers("id|og").ToList()   },
		                new Key { Index = 90 , Print="Z", Token="Z",       LineIndex=2, LinePosition=2,  Shifted=true , Fingers= GetFingers("ag|od").ToList() },
		                new Key { Index = 91 , Print="[", Token="lbracket",       LineIndex=1, LinePosition=5,  Shifted=false, Fingers= GetFingers("ig|pd").ToList(), AltGred=true   },
		                new Key { Index = 92 , Print="\\", Token="backslash",     LineIndex=1, LinePosition=8,  Shifted=false, Fingers= GetFingers("md|pd").ToList(), AltGred=true  },
		                new Key { Index = 93 , Print="]", Token="rbracket",       LineIndex=1, LinePosition=11, Shifted=false, Fingers= GetFingers("od|pd").ToList(), AltGred=true  },
		                new Key { Index = 94 , Print="^", Token="circ",       LineIndex=2, LinePosition=11, Shifted=false, Fingers= GetFingers("og").ToList()  },
		                new Key { Index = 95 , Print="_", Token="underscore",       LineIndex=1, LinePosition=8,  Shifted=false, Fingers= GetFingers("md").ToList()  },
		                new Key { Index = 96 , Print="`", Token="grave",       LineIndex=1, LinePosition=7,  Shifted=false, Fingers= GetFingers("id").ToList() , AltGred=true   },
		                new Key { Index = 97 , Print="a", Token="a",       LineIndex=2, LinePosition=1,  Shifted=false, Fingers= GetFingers("og").ToList()  },
		                new Key { Index = 98 , Print="b", Token="b",       LineIndex=4, LinePosition=6,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 99 , Print="c", Token="c",       LineIndex=4, LinePosition=4,  Shifted=false, Fingers= GetFingers("mg").ToList()  },
		                new Key { Index = 100, Print="d", Token="d",       LineIndex=3, LinePosition=3,  Shifted=false, Fingers= GetFingers("mg").ToList()  },
		                new Key { Index = 101, Print="e", Token="e",       LineIndex=2, LinePosition=3,  Shifted=false, Fingers= GetFingers("mg").ToList()  },
		                new Key { Index = 102, Print="f", Token="f",       LineIndex=3, LinePosition=4,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 103, Print="g", Token="g",       LineIndex=3, LinePosition=5,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 104, Print="h", Token="h",       LineIndex=3, LinePosition=6,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 105, Print="i", Token="i",       LineIndex=2, LinePosition=8,  Shifted=false, Fingers= GetFingers("md").ToList()  },
		                new Key { Index = 106, Print="j", Token="j",       LineIndex=3, LinePosition=7,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 107, Print="k", Token="k",       LineIndex=3, LinePosition=8,  Shifted=false, Fingers= GetFingers("md").ToList()  },
		                new Key { Index = 108, Print="l", Token="l",       LineIndex=3, LinePosition=9,  Shifted=false, Fingers= GetFingers("ad").ToList()  },
		                new Key { Index = 109, Print="m", Token="m",       LineIndex=3, LinePosition=10, Shifted=false, Fingers= GetFingers("od").ToList()  },
		                new Key { Index = 110, Print="n", Token="n",       LineIndex=4, LinePosition=7,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 111, Print="o", Token="o",       LineIndex=2, LinePosition=9,  Shifted=false, Fingers= GetFingers("ad").ToList()  },
		                new Key { Index = 112, Print="p", Token="p",       LineIndex=2, LinePosition=10, Shifted=false, Fingers= GetFingers("od").ToList()  },
		                new Key { Index = 113, Print="q", Token="q",       LineIndex=3, LinePosition=1,  Shifted=false, Fingers= GetFingers("og").ToList()  },
		                new Key { Index = 114, Print="r", Token="r",       LineIndex=2, LinePosition=4,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 115, Print="s", Token="s",       LineIndex=3, LinePosition=2,  Shifted=false, Fingers= GetFingers("ag").ToList()  },
		                new Key { Index = 116, Print="t", Token="t",       LineIndex=2, LinePosition=5,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 117, Print="u", Token="u",       LineIndex=2, LinePosition=7,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 118, Print="v", Token="v",       LineIndex=4, LinePosition=5,  Shifted=false, Fingers= GetFingers("ig").ToList()  },
		                new Key { Index = 119, Print="w", Token="w",       LineIndex=4, LinePosition=2,  Shifted=false, Fingers= GetFingers("og").ToList()  },
		                new Key { Index = 120, Print="x", Token="x",       LineIndex=4, LinePosition=3,  Shifted=false, Fingers= GetFingers("ag").ToList()  },
		                new Key { Index = 121, Print="y", Token="y",       LineIndex=2, LinePosition=6,  Shifted=false, Fingers= GetFingers("id").ToList()  },
		                new Key { Index = 122, Print="z", Token="z",       LineIndex=2, LinePosition=2,  Shifted=false, Fingers= GetFingers("ag").ToList()  },
		                new Key { Index = 123, Print="{", Token="lbrace",       LineIndex=1, LinePosition=4,  Shifted=false, Fingers= GetFingers("ig|pd").ToList() , AltGred=true  },
		                new Key { Index = 124, Print="|", Token="pipe",       LineIndex=1, LinePosition=6,  Shifted=false, Fingers= GetFingers("id|pd").ToList() , AltGred=true  },
		                new Key { Index = 125, Print="}", Token="rbrace",       LineIndex=1, LinePosition=12, Shifted=false, Fingers= GetFingers("od|pd").ToList() , AltGred=true  },
		                new Key { Index = 126, Print="~", Token="tilde",       LineIndex=1, LinePosition=2,  Shifted=false, Fingers= GetFingers("ag|pd").ToList() , AltGred=true  },
		                new Key { Index = 126, Print="é", Token="eacute",       LineIndex=1, LinePosition=2,  Shifted=false, Fingers= GetFingers("ag").ToList()    },
		                new Key { Index = 126, Print="è", Token="egrave",       LineIndex=1, LinePosition=7,  Shifted=false, Fingers= GetFingers("id").ToList()    },
		                new Key { Index = 126, Print="ç", Token="ccedil",       LineIndex=1, LinePosition=9,  Shifted=false, Fingers= GetFingers("ad").ToList()    },
		                new Key { Index = 126, Print="à", Token="agrave",       LineIndex=1, LinePosition=10, Shifted=false, Fingers= GetFingers("od").ToList()    },
		                new Key { Index = 126, Print="ù", Token="ugrave",       LineIndex=3, LinePosition=11, Shifted=false, Fingers= GetFingers("od").ToList()    }
                };

        }

        public void CreateLessons()
        {
            Lessons = new List<Lesson> 
            { 
                
            new Lesson { Name = DoTitle(_lessonsShort[0]), WorkedChars = GetKeyList(_lessonsShort[0]), KnownChars = null },
            new Lesson { Name = DoTitle(_lessonsShort[1]), WorkedChars = GetKeyList(_lessonsShort[1]), KnownChars = GetKnownChars(1) },
            new Lesson { Name = DoTitle(_lessonsShort[2]), WorkedChars = GetKeyList(_lessonsShort[2]), KnownChars = GetKnownChars(2) },
            new Lesson { Name = DoTitle(_lessonsShort[3]), WorkedChars = GetKeyList(_lessonsShort[3]), KnownChars = GetKnownChars(3) },
            new Lesson { Name = DoTitle(_lessonsShort[4]), WorkedChars = GetKeyList(_lessonsShort[4]), KnownChars = GetKnownChars(4) },
            new Lesson { Name = DoTitle(_lessonsShort[5]), WorkedChars = GetKeyList(_lessonsShort[5]), KnownChars = GetKnownChars(5) },
            new Lesson { Name = DoTitle(_lessonsShort[6]), WorkedChars = GetKeyList(_lessonsShort[6]), KnownChars = GetKnownChars(6) },
            new Lesson { Name = DoTitle(_lessonsShort[7]), WorkedChars = GetKeyList(_lessonsShort[7]), KnownChars = GetKnownChars(7) },
            new Lesson { Name = DoTitle(_lessonsShort[8]), WorkedChars = GetKeyList(_lessonsShort[8]), KnownChars = GetKnownChars(8) },
            new Lesson { Name = DoTitle(_lessonsShort[9]), WorkedChars = GetKeyList(_lessonsShort[9]), KnownChars = GetKnownChars(9) },
            new Lesson { Name = DoTitle(_lessonsShort[10]), WorkedChars =GetKeyList(_lessonsShort[10]), KnownChars = GetKnownChars(10) },
            new Lesson { Name = DoTitle(_lessonsShort[11]), WorkedChars =GetKeyList(_lessonsShort[11]), KnownChars = GetKnownChars(11) },
            new Lesson { Name = DoTitle(_lessonsShort[12]), WorkedChars =GetKeyList(_lessonsShort[12]), KnownChars = GetKnownChars(12) },
            new Lesson { Name = DoTitle(_lessonsShort[13]), WorkedChars =GetKeyList(_lessonsShort[13]), KnownChars = GetKnownChars(13) },
            new Lesson { Name = DoTitle(_lessonsShort[14]), WorkedChars =GetKeyList(_lessonsShort[14]), KnownChars = GetKnownChars(14) },

            };


        }

        public void CreateChapters()
        {
            Chapters = new List<Chapter> {
                new Chapter
                {
                    Name = "Les touches de base",
                    Description = "On entame naturellement avec les touches de base : les lettres de l'alphabet et quelques ponctuations !",
                    Lessons = Lessons
                }
            };
        }

        private IEnumerable<Finger> GetFingers(string input)
        {
            var fingerTokens = input.Split('|');
            foreach (string item in fingerTokens)
            {
                yield return Fingers.Where(f => f.Code == item).FirstOrDefault();
            }
        }

        private string DoTitle(string twoChars)
        {
            return string.Format("{0} & {1}", twoChars[0], twoChars[1]);
        }

        private List<Key> GetKeyList(string input)
        {
            return input.ToCharArray().ToList().ConvertAll(c => Keys.Where(k => k.Print == c.ToString()).FirstOrDefault());
        }

        private List<Key> GetKnownChars(int take)
        {
            return _lessonsShort.Take(take).Aggregate(string.Empty, string.Concat).ToCharArray().ToList().ConvertAll(c => Keys.Where(k => k.Print == c.ToString()).FirstOrDefault());
        }
    }
}
