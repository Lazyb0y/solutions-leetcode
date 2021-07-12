namespace LeetCodeSolutions
{
    public class Solution
    {
        public string Interpret(string command)
        {
            string result = string.Empty;

            string commandPart = string.Empty;
            for (int i = 0; i < command.Length;)
            {
                while (true)
                {
                    if (commandPart == "G")
                    {
                        result += "G";
                        commandPart = string.Empty;
                        break;
                    }

                    if (commandPart == "()")
                    {
                        result += "o";
                        commandPart = string.Empty;
                        break;
                    }

                    if (commandPart == "(al)")
                    {
                        result += "al";
                        commandPart = string.Empty;
                        break;
                    }

                    commandPart = commandPart + command[i];
                    i++;
                }
            }

            return result;
        }
    }
}