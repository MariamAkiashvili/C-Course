
namespace Task09
{
    public static class Show
    {
        public static void GetMembers(Category category, List <Vehicle> members)
        {
            if(category != null)
            {
                Console.WriteLine("Category " + (int)category + " : " + category);
            }
           
            for (int i = 0; i < members.Count; i++)
            {
                Console.Write(members[i].Name);
                if(i < members.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void GetMembers(List<Vehicle> members)
        {
            for (int i = 0; i < members.Count; i++)
            {
                Console.Write("ID - "+i+" - "+members[i].Name);
                if (i < members.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}

