namespace BookStore.DL.Interfaces
{
     public interface
        {
          List<Author> GetAll();

    Author GetById(int id);

    void Add(Author author);

    void Remove(int id);
    }
  
