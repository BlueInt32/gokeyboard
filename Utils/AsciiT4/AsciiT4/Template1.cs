 
//Generated Code Test  
//Class: Template1.cs//Author:NET\simon.budin 
//Date:01/24/2014 14:13:44. 

using GoKeyboard.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordListManager
{
    public class ProgramAsciiCreator
    {
        SortedList<int, GkKey> GkKeys { get; set; }
        public ProgramAsciiCreator()
        {
            GkKeys = new SortedList<int, GkKey>
            {
	{ 32, new GkKey { AsciiCode = 32, Print=" ", Token=" "  }  },
		{ 33, new GkKey { AsciiCode = 33, Print="!", Token="!"  }  },
		{ 34, new GkKey { AsciiCode = 34, Print="\"", Token="\""  }  },
		{ 35, new GkKey { AsciiCode = 35, Print="#", Token="#"  }  },
		{ 36, new GkKey { AsciiCode = 36, Print="$", Token="$"  }  },
		{ 37, new GkKey { AsciiCode = 37, Print="%", Token="%"  }  },
		{ 38, new GkKey { AsciiCode = 38, Print="&", Token="&"  }  },
		{ 39, new GkKey { AsciiCode = 39, Print="'", Token="'"  }  },
		{ 40, new GkKey { AsciiCode = 40, Print="(", Token="("  }  },
		{ 41, new GkKey { AsciiCode = 41, Print=")", Token=")"  }  },
		{ 42, new GkKey { AsciiCode = 42, Print="*", Token="*"  }  },
		{ 43, new GkKey { AsciiCode = 43, Print="+", Token="+"  }  },
		{ 44, new GkKey { AsciiCode = 44, Print=",", Token=","  }  },
		{ 45, new GkKey { AsciiCode = 45, Print="-", Token="-"  }  },
		{ 46, new GkKey { AsciiCode = 46, Print=".", Token="."  }  },
		{ 47, new GkKey { AsciiCode = 47, Print="/", Token="/"  }  },
		{ 48, new GkKey { AsciiCode = 48, Print="0", Token="0"  }  },
		{ 49, new GkKey { AsciiCode = 49, Print="1", Token="1"  }  },
		{ 50, new GkKey { AsciiCode = 50, Print="2", Token="2"  }  },
		{ 51, new GkKey { AsciiCode = 51, Print="3", Token="3"  }  },
		{ 52, new GkKey { AsciiCode = 52, Print="4", Token="4"  }  },
		{ 53, new GkKey { AsciiCode = 53, Print="5", Token="5"  }  },
		{ 54, new GkKey { AsciiCode = 54, Print="6", Token="6"  }  },
		{ 55, new GkKey { AsciiCode = 55, Print="7", Token="7"  }  },
		{ 56, new GkKey { AsciiCode = 56, Print="8", Token="8"  }  },
		{ 57, new GkKey { AsciiCode = 57, Print="9", Token="9"  }  },
		{ 58, new GkKey { AsciiCode = 58, Print=":", Token=":"  }  },
		{ 59, new GkKey { AsciiCode = 59, Print=";", Token=";"  }  },
		{ 60, new GkKey { AsciiCode = 60, Print="<", Token="<"  }  },
		{ 61, new GkKey { AsciiCode = 61, Print="=", Token="="  }  },
		{ 62, new GkKey { AsciiCode = 62, Print=">", Token=">"  }  },
		{ 63, new GkKey { AsciiCode = 63, Print="?", Token="?"  }  },
		{ 64, new GkKey { AsciiCode = 64, Print="@", Token="@"  }  },
		{ 65, new GkKey { AsciiCode = 65, Print="A", Token="A"  }  },
		{ 66, new GkKey { AsciiCode = 66, Print="B", Token="B"  }  },
		{ 67, new GkKey { AsciiCode = 67, Print="C", Token="C"  }  },
		{ 68, new GkKey { AsciiCode = 68, Print="D", Token="D"  }  },
		{ 69, new GkKey { AsciiCode = 69, Print="E", Token="E"  }  },
		{ 70, new GkKey { AsciiCode = 70, Print="F", Token="F"  }  },
		{ 71, new GkKey { AsciiCode = 71, Print="G", Token="G"  }  },
		{ 72, new GkKey { AsciiCode = 72, Print="H", Token="H"  }  },
		{ 73, new GkKey { AsciiCode = 73, Print="I", Token="I"  }  },
		{ 74, new GkKey { AsciiCode = 74, Print="J", Token="J"  }  },
		{ 75, new GkKey { AsciiCode = 75, Print="K", Token="K"  }  },
		{ 76, new GkKey { AsciiCode = 76, Print="L", Token="L"  }  },
		{ 77, new GkKey { AsciiCode = 77, Print="M", Token="M"  }  },
		{ 78, new GkKey { AsciiCode = 78, Print="N", Token="N"  }  },
		{ 79, new GkKey { AsciiCode = 79, Print="O", Token="O"  }  },
		{ 80, new GkKey { AsciiCode = 80, Print="P", Token="P"  }  },
		{ 81, new GkKey { AsciiCode = 81, Print="Q", Token="Q"  }  },
		{ 82, new GkKey { AsciiCode = 82, Print="R", Token="R"  }  },
		{ 83, new GkKey { AsciiCode = 83, Print="S", Token="S"  }  },
		{ 84, new GkKey { AsciiCode = 84, Print="T", Token="T"  }  },
		{ 85, new GkKey { AsciiCode = 85, Print="U", Token="U"  }  },
		{ 86, new GkKey { AsciiCode = 86, Print="V", Token="V"  }  },
		{ 87, new GkKey { AsciiCode = 87, Print="W", Token="W"  }  },
		{ 88, new GkKey { AsciiCode = 88, Print="X", Token="X"  }  },
		{ 89, new GkKey { AsciiCode = 89, Print="Y", Token="Y"  }  },
		{ 90, new GkKey { AsciiCode = 90, Print="Z", Token="Z"  }  },
		{ 91, new GkKey { AsciiCode = 91, Print="[", Token="["  }  },
		{ 92, new GkKey { AsciiCode = 92, Print="\", Token="\"  }  },
		{ 93, new GkKey { AsciiCode = 93, Print="]", Token="]"  }  },
		{ 94, new GkKey { AsciiCode = 94, Print="^", Token="^"  }  },
		{ 95, new GkKey { AsciiCode = 95, Print="_", Token="_"  }  },
		{ 96, new GkKey { AsciiCode = 96, Print="`", Token="`"  }  },
		{ 97, new GkKey { AsciiCode = 97, Print="a", Token="a"  }  },
		{ 98, new GkKey { AsciiCode = 98, Print="b", Token="b"  }  },
		{ 99, new GkKey { AsciiCode = 99, Print="c", Token="c"  }  },
		{ 100, new GkKey { AsciiCode = 100, Print="d", Token="d"  }  },
		{ 101, new GkKey { AsciiCode = 101, Print="e", Token="e"  }  },
		{ 102, new GkKey { AsciiCode = 102, Print="f", Token="f"  }  },
		{ 103, new GkKey { AsciiCode = 103, Print="g", Token="g"  }  },
		{ 104, new GkKey { AsciiCode = 104, Print="h", Token="h"  }  },
		{ 105, new GkKey { AsciiCode = 105, Print="i", Token="i"  }  },
		{ 106, new GkKey { AsciiCode = 106, Print="j", Token="j"  }  },
		{ 107, new GkKey { AsciiCode = 107, Print="k", Token="k"  }  },
		{ 108, new GkKey { AsciiCode = 108, Print="l", Token="l"  }  },
		{ 109, new GkKey { AsciiCode = 109, Print="m", Token="m"  }  },
		{ 110, new GkKey { AsciiCode = 110, Print="n", Token="n"  }  },
		{ 111, new GkKey { AsciiCode = 111, Print="o", Token="o"  }  },
		{ 112, new GkKey { AsciiCode = 112, Print="p", Token="p"  }  },
		{ 113, new GkKey { AsciiCode = 113, Print="q", Token="q"  }  },
		{ 114, new GkKey { AsciiCode = 114, Print="r", Token="r"  }  },
		{ 115, new GkKey { AsciiCode = 115, Print="s", Token="s"  }  },
		{ 116, new GkKey { AsciiCode = 116, Print="t", Token="t"  }  },
		{ 117, new GkKey { AsciiCode = 117, Print="u", Token="u"  }  },
		{ 118, new GkKey { AsciiCode = 118, Print="v", Token="v"  }  },
		{ 119, new GkKey { AsciiCode = 119, Print="w", Token="w"  }  },
		{ 120, new GkKey { AsciiCode = 120, Print="x", Token="x"  }  },
		{ 121, new GkKey { AsciiCode = 121, Print="y", Token="y"  }  },
		{ 122, new GkKey { AsciiCode = 122, Print="z", Token="z"  }  },
		{ 123, new GkKey { AsciiCode = 123, Print="{", Token="{"  }  },
		{ 124, new GkKey { AsciiCode = 124, Print="|", Token="|"  }  },
		{ 125, new GkKey { AsciiCode = 125, Print="}", Token="}"  }  },
		{ 126, new GkKey { AsciiCode = 126, Print="~", Token="~"  }  },
	
            };

        }


    }
}
