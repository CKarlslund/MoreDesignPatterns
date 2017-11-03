using DesignPatternsLib;

namespace DesignPatternsTestsLib
{
    internal class SwedishAdapter :IEnglish 
    {
        private readonly ISwedish _swedish;

        public SwedishAdapter(ISwedish swedish)
        {
            _swedish = swedish;
        }

        public string Hello()
        {
            return _swedish.Hej();
        }
    }
}