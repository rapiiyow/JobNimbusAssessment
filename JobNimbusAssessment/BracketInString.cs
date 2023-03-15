namespace JobNimbusAssessment
{
    public class BracketInString
    {
        public bool isValidBracket(string text)
        {
            bool isValid = true;
            int openBracket = 0;
            foreach (var t in text.ToCharArray())
            {
                if (openBracket <= 0 && t == '}')
                {
                    return false;
                }
                else if (openBracket > 0 && t == '}')
                {
                    openBracket--;
                    continue;
                }
                else if (t == '{')
                {
                    openBracket++;
                    continue;
                }
            }

            if (openBracket > 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
