using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLib
{
    public class SwedishSpeaker :ISwedish
    {
        public string Hej()
        {
            return "Hejsan!";
        }
    }
}
