public class DbContext
{
    public IList<Todo> Todos { get; } = new List<Todo>();
    public IList<Book> Books { get; } = new List<Book>();
}

public static class ListExtensions
{
    public static Todo Find(this IList<Todo> list, int id)
    {
        return new Todo { Text = $"Todo item {id}" };
    }

    public static Book Find(this IList<Book> list, int id)
    {
        return new Book { Text = $"Book item {id}" };
    }
}

public class Todo
{
    public string Text { get; set; }
}

public class Book
{
    public string Text { get; set; }
}
