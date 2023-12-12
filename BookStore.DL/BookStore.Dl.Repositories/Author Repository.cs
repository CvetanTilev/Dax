using BookStore.DL.MemoryDb;

namespace BookStore.DL.BookStore.Dl.Repositories
{
     public List<Author> GetAll()
     {
        return InMemoryDb.AuthorData;
    }

    public Author GetById(int id)
    {
        return InMemoryDb.AuthorData// List<Author>
            .First(a Author => a.Id = id );// Author
    }
}
