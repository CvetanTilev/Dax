namespace BookStore.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> AuthorData = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Jhin",
                BirthDay = DateTime.Now
            },
            new Author()
            {
                Id = 2,
                Name = "Darius",
                BirthDay = DateTime.Now
            },
            new Author()
            {
                Id = 3,
                Name = "Jinx",
                BirthDay = DateTime.Now
            },
        }


    }
}
