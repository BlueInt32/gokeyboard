using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using GoKeyboard.DTO;
using Tools;

namespace GoKeyboard.DAL
{
	public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
	{
		readonly List<string> _lessonsShort = new List<string> { "fj", "ei", "dk", "sl", "qm", "ru", "zo", "ap", "gh", "ty", "vn", "b,", "c;", "x:", "w!" };

		protected override void Seed(DataContext context)
		{
			log4net.Config.XmlConfigurator.Configure();
			Log.InfoFormat("Global.asax", "Application_Start");


			#region Keys & Fingers

            List<GkFinger> fingers = new List<GkFinger>
            {
                new GkFinger
            {
                Code = "id",
                Name = "Index droit",
                //Keys = GetListKeysFromStr("ujnyh,è-UJNYH?76", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "md",
                Name = "Majeur droit",
                //Keys = GetListKeysFromStr("ik;_IK.8", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "ad",
                Name = "Annulaire droit",
                //Keys = GetListKeysFromStr("ol:çOL/9", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "od",
                Name = "Auriculaire droit",
                //Keys = GetListKeysFromStr("pm!à)=PM§0°+" + "RFVTGB54EDC3ZSX2AQW1", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "pd",
                Name = "Pouce droit",
                //Keys = GetListKeysFromStr(" ", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "ig",
                Name = "Index gauche",
                //Keys = GetListKeysFromStr("rfvtgb('RFVTGB54", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "mg",
                Name = "Majeur gauche",
                //Keys = GetListKeysFromStr("edc\",EDC3", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "ag",
                Name = "Annulaire gauche",
                //Keys = GetListKeysFromStr("zsxéZSX2", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "og",
                Name = "Auriculaire gauche",
                //Keys = GetListKeysFromStr("aqw&AQW1UJNYH?76IK.8OL/9PM§0°+", context.GkKeys).ToList()
            },
            new GkFinger
            {
                Code = "pg",
                Name = "Pouce gauche",
            }

            };

            //Base 
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "id",
            //    Name = "Index droit",
            //    //Keys = GetListKeysFromStr("ujnyh,è-UJNYH?76", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "md",
            //    Name = "Majeur droit",
            //    //Keys = GetListKeysFromStr("ik;_IK.8", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "ad",
            //    Name = "Annulaire droit",
            //    //Keys = GetListKeysFromStr("ol:çOL/9", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "od",
            //    Name = "Auriculaire droit",
            //    //Keys = GetListKeysFromStr("pm!à)=PM§0°+" + "RFVTGB54EDC3ZSX2AQW1", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "pd",
            //    Name = "Pouce droit",
            //    //Keys = GetListKeysFromStr(" ", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "ig",
            //    Name = "Index gauche",
            //    //Keys = GetListKeysFromStr("rfvtgb('RFVTGB54", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "mg",
            //    Name = "Majeur gauche",
            //    //Keys = GetListKeysFromStr("edc\",EDC3", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "ag",
            //    Name = "Annulaire gauche",
            //    //Keys = GetListKeysFromStr("zsxéZSX2", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "og",
            //    Name = "Auriculaire gauche",
            //    //Keys = GetListKeysFromStr("aqw&AQW1UJNYH?76IK.8OL/9PM§0°+", context.GkKeys).ToList()
            //});
            //context.GkFingers.AddOrUpdate(new GkFinger
            //{
            //    Code = "pg",
            //    Name = "Pouce gauche",
            //});

            context.GkKeys.AddOrUpdate(new List<GkKey>
            {
                {new GkKey { Index = 32 , Print=" ", Token="[space]", LineIndex=4, LinePosition=11, Shifted=false, Fingers= GetListFingersFromStr("pd", fingers).ToList() }  },
		        {new GkKey { Index = 33 , Print="!", Token="!",       LineIndex=4, LinePosition=11, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 34 , Print="\"", Token="\"",     LineIndex=1, LinePosition=3,  Shifted=false, Fingers= GetListFingersFromStr("pd|md", fingers).ToList() } }  },
		        {new GkKey { Index = 35 , Print="#", Token="#",       LineIndex=1, LinePosition=3,  Shifted=false, Fingers= GetListFingersFromStr("pd|mg", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 36 , Print="$", Token="$",       LineIndex=2, LinePosition=12, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 37 , Print="%", Token="%",       LineIndex=3, LinePosition=11, Shifted=true , Fingers= GetListFingersFromStr("od|og", fingers).ToList() }}  },
		        {new GkKey { Index = 38 , Print="&", Token="&",       LineIndex=1, LinePosition=1,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 39 , Print="'", Token="'",       LineIndex=1, LinePosition=4,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 40 , Print="(", Token="(",       LineIndex=1, LinePosition=5,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 41 , Print=")", Token=")",       LineIndex=1, LinePosition=11, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 42 , Print="*", Token="*",       LineIndex=3, LinePosition=12, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 43 , Print="+", Token="+",       LineIndex=3, LinePosition=12, Shifted=true , Fingers= GetListFingersFromStr("od|og", fingers).ToList() }}  },
		        {new GkKey { Index = 44 , Print=",", Token=",",       LineIndex=4, LinePosition=8,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 45 , Print="-", Token="-",       LineIndex=1, LinePosition=6,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 46 , Print=".", Token=".",       LineIndex=4, LinePosition=9,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 47 , Print="/", Token="/",       LineIndex=4, LinePosition=10, Shifted=true , Fingers= GetListFingersFromStr("ad", fingers).ToList() }}  },
		        {new GkKey { Index = 48 , Print="0", Token="0",       LineIndex=1, LinePosition=10, Shifted=true , Fingers= GetListFingersFromStr("od|og", fingers).ToList() }}  },
		        {new GkKey { Index = 49 , Print="1", Token="1",       LineIndex=1, LinePosition=1,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 50 , Print="2", Token="2",       LineIndex=1, LinePosition=2,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 51 , Print="3", Token="3",       LineIndex=1, LinePosition=3,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 52 , Print="4", Token="4",       LineIndex=1, LinePosition=4,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 53 , Print="5", Token="5",       LineIndex=1, LinePosition=5,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 54 , Print="6", Token="6",       LineIndex=1, LinePosition=6,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 55 , Print="7", Token="7",       LineIndex=1, LinePosition=7,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 56 , Print="8", Token="8",       LineIndex=1, LinePosition=8,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 57 , Print="9", Token="9",       LineIndex=1, LinePosition=9,  Shifted=true , Fingers= GetListFingersFromStr("ad", fingers).ToList() }}  },
		        {new GkKey { Index = 58 , Print=":", Token=":",       LineIndex=4, LinePosition=10, Shifted=false, Fingers= GetListFingersFromStr("ad", fingers).ToList() } }  },
		        {new GkKey { Index = 59 , Print=";", Token=";",       LineIndex=4, LinePosition=9,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 60 , Print="<", Token="<",       LineIndex=4, LinePosition=1,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 61 , Print="=", Token="=",       LineIndex=1, LinePosition=12, Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 62 , Print=">", Token=">",       LineIndex=4, LinePosition=1,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 63 , Print="?", Token="?",       LineIndex=4, LinePosition=8,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 64 , Print="@", Token="@",       LineIndex=1, LinePosition=10, Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 65 , Print="A", Token="A",       LineIndex=2, LinePosition=1,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 66 , Print="B", Token="B",       LineIndex=4, LinePosition=6,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 67 , Print="C", Token="C",       LineIndex=4, LinePosition=4,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 68 , Print="D", Token="D",       LineIndex=3, LinePosition=3,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 69 , Print="E", Token="E",       LineIndex=2, LinePosition=3,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 70 , Print="F", Token="F",       LineIndex=3, LinePosition=4,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 71 , Print="G", Token="G",       LineIndex=3, LinePosition=5,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 72 , Print="H", Token="H",       LineIndex=3, LinePosition=6,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 73 , Print="I", Token="I",       LineIndex=2, LinePosition=8,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 74 , Print="J", Token="J",       LineIndex=3, LinePosition=7,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 75 , Print="K", Token="K",       LineIndex=3, LinePosition=8,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 76 , Print="L", Token="L",       LineIndex=3, LinePosition=9,  Shifted=true , Fingers= GetListFingersFromStr("ad", fingers).ToList() }}  },
		        {new GkKey { Index = 77 , Print="M", Token="M",       LineIndex=3, LinePosition=10, Shifted=true , Fingers= GetListFingersFromStr("od", fingers).ToList() }}  },
		        {new GkKey { Index = 78 , Print="N", Token="N",       LineIndex=4, LinePosition=7,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 79 , Print="O", Token="O",       LineIndex=2, LinePosition=9,  Shifted=true , Fingers= GetListFingersFromStr("ad", fingers).ToList() }}  },
		        {new GkKey { Index = 80 , Print="P", Token="P",       LineIndex=2, LinePosition=10, Shifted=true , Fingers= GetListFingersFromStr("od", fingers).ToList() }}  },
		        {new GkKey { Index = 81 , Print="Q", Token="Q",       LineIndex=3, LinePosition=1,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 82 , Print="R", Token="R",       LineIndex=2, LinePosition=4,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 83 , Print="S", Token="S",       LineIndex=3, LinePosition=2,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 84 , Print="T", Token="T",       LineIndex=2, LinePosition=5,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 85 , Print="U", Token="U",       LineIndex=2, LinePosition=7,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 86 , Print="V", Token="V",       LineIndex=4, LinePosition=5,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 87 , Print="W", Token="W",       LineIndex=4, LinePosition=2,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 88 , Print="X", Token="X",       LineIndex=4, LinePosition=3,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 89 , Print="Y", Token="Y",       LineIndex=2, LinePosition=6,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 90 , Print="Z", Token="Z",       LineIndex=2, LinePosition=2,  Shifted=true , Fingers= GetListFingersFromStr("", fingers).ToList() }}  },
		        {new GkKey { Index = 91 , Print="[", Token="[",       LineIndex=1, LinePosition=5,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 92 , Print="\\", Token="\\",     LineIndex=1, LinePosition=8,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 93 , Print="]", Token="]",       LineIndex=1, LinePosition=11, Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 94 , Print="^", Token="^",       LineIndex=2, LinePosition=11, Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }  }  },
		        {new GkKey { Index = 95 , Print="_", Token="_",       LineIndex=1, LinePosition=8,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }  }  },
		        {new GkKey { Index = 96 , Print="`", Token="`",       LineIndex=1, LinePosition=7,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 97 , Print="a", Token="a",       LineIndex=2, LinePosition=1,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 98 , Print="b", Token="b",       LineIndex=4, LinePosition=6,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 99 , Print="c", Token="c",       LineIndex=4, LinePosition=4,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 100, Print="d", Token="d",       LineIndex=3, LinePosition=3,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 101, Print="e", Token="e",       LineIndex=2, LinePosition=3,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 102, Print="f", Token="f",       LineIndex=3, LinePosition=4,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 103, Print="g", Token="g",       LineIndex=3, LinePosition=5,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 104, Print="h", Token="h",       LineIndex=3, LinePosition=6,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 105, Print="i", Token="i",       LineIndex=2, LinePosition=8,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 106, Print="j", Token="j",       LineIndex=3, LinePosition=7,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 107, Print="k", Token="k",       LineIndex=3, LinePosition=8,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 108, Print="l", Token="l",       LineIndex=3, LinePosition=9,  Shifted=false, Fingers= GetListFingersFromStr("ad", fingers).ToList() } }  },
		        {new GkKey { Index = 109, Print="m", Token="m",       LineIndex=3, LinePosition=10, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 110, Print="n", Token="n",       LineIndex=4, LinePosition=7,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 111, Print="o", Token="o",       LineIndex=2, LinePosition=9,  Shifted=false, Fingers= GetListFingersFromStr("ad", fingers).ToList() } }  },
		        {new GkKey { Index = 112, Print="p", Token="p",       LineIndex=2, LinePosition=10, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 113, Print="q", Token="q",       LineIndex=3, LinePosition=1,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 114, Print="r", Token="r",       LineIndex=2, LinePosition=4,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 115, Print="s", Token="s",       LineIndex=3, LinePosition=2,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 116, Print="t", Token="t",       LineIndex=2, LinePosition=5,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 117, Print="u", Token="u",       LineIndex=2, LinePosition=7,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 118, Print="v", Token="v",       LineIndex=4, LinePosition=5,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 119, Print="w", Token="w",       LineIndex=4, LinePosition=2,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 120, Print="x", Token="x",       LineIndex=4, LinePosition=3,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 121, Print="y", Token="y",       LineIndex=2, LinePosition=6,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 122, Print="z", Token="z",       LineIndex=2, LinePosition=2,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 123, Print="{", Token="{",       LineIndex=1, LinePosition=4,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 124, Print="|", Token="|",       LineIndex=1, LinePosition=6,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 125, Print="}", Token="}",       LineIndex=1, LinePosition=12, Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 126, Print="~", Token="~",       LineIndex=1, LinePosition=2,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() }, AltGred=true  }  },
		        {new GkKey { Index = 126, Print="é", Token="é",       LineIndex=1, LinePosition=2,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 126, Print="è", Token="è",       LineIndex=1, LinePosition=7,  Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  },
		        {new GkKey { Index = 126, Print="ç", Token="ç",       LineIndex=1, LinePosition=9,  Shifted=false, Fingers= GetListFingersFromStr("ad", fingers).ToList() } }  },
		        {new GkKey { Index = 126, Print="à", Token="à",       LineIndex=1, LinePosition=10, Shifted=false, Fingers= GetListFingersFromStr("od", fingers).ToList() } }  },
		        {new GkKey { Index = 126, Print="ù", Token="ù",       LineIndex=2, LinePosition=11, Shifted=false, Fingers= GetListFingersFromStr("", fingers).ToList() } }  }
            }.ToArray());


			#endregion

			#region Lessons

			GkChapter chapter1 = new GkChapter
			{
				Name = "Les touches de base",
				Description = "On entame naturellement avec les touches de base : les lettres de l'alphabet et quelques ponctuations !"
			};
			context.GkChapters.AddOrUpdate(c => c.Name, chapter1);
			//Log.Info("Seed", GetKnownChars(context));


            context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[0]), WorkedChars = _lessonsShort[0], KnownChars = string.Empty });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[1]), WorkedChars = _lessonsShort[1], KnownChars = GetKnownChars(1) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[2]), WorkedChars = _lessonsShort[2], KnownChars = GetKnownChars(2) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[3]), WorkedChars = _lessonsShort[3], KnownChars = GetKnownChars(3) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[4]), WorkedChars = _lessonsShort[4], KnownChars = GetKnownChars(4) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[5]), WorkedChars = _lessonsShort[5], KnownChars = GetKnownChars(5) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[6]), WorkedChars = _lessonsShort[6], KnownChars = GetKnownChars(6) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[7]), WorkedChars = _lessonsShort[7], KnownChars = GetKnownChars(7) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[8]), WorkedChars = _lessonsShort[8], KnownChars = GetKnownChars(8) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[9]), WorkedChars = _lessonsShort[9], KnownChars = GetKnownChars(9) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[10]), WorkedChars = _lessonsShort[10], KnownChars = GetKnownChars(10) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[11]), WorkedChars = _lessonsShort[11], KnownChars = GetKnownChars(11) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[12]), WorkedChars = _lessonsShort[12], KnownChars = GetKnownChars(12) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[13]), WorkedChars = _lessonsShort[13], KnownChars = GetKnownChars(13) });
			context.GkLessons.AddOrUpdate(l => l.Name, new GkLesson { Chapter = chapter1, Name = DoTitle(_lessonsShort[14]), WorkedChars = _lessonsShort[14], KnownChars = GetKnownChars(14) });

			#endregion
			context.SaveChanges();
		}

		private string GetKnownChars(int take)
		{
			return _lessonsShort.Take(take).Aggregate(string.Empty, string.Concat);
		}

		private string DoTitle(string twoChars)
		{
			return string.Format("{0} & {1}", twoChars[0], twoChars[1]);
		}

        private IEnumerable<GkKey> GetListKeysFromStr(string input, DbSet<GkKey> keys)
        {
            foreach (char c in input)
            {
                string strC = c.ToString();
                yield return keys.Where(k => k.Print == strC).FirstOrDefault();
            }

        }

        private IEnumerable<GkFinger> GetListFingersFromStr(string input, List<GkFinger> fingers)
        {
            var fingerTokens = input.Split('|');
            foreach (string item in fingerTokens)
            {
                yield return fingers.Where(f => f.Code == item).FirstOrDefault();
            }

        }
	}
}
