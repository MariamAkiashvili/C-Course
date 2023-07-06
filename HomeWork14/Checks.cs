
namespace HomeWork14
{
    public static class Checks
    {

        public static bool CheckIsNotEmpty(string value)
        {
            if (value == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckIsNotEmpty(List<string> list)
        {
            foreach (var item in list)
            {
                if (item == "") 
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
