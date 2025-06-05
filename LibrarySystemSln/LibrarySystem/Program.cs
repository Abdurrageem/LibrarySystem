namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding the Items into the library.
            List<LibraryItem> libraryItems = new List<LibraryItem>();
            libraryItems.Add(new Book(1, "To Kill a Mockingbird, 1960, Harper Lee, Fiction"));
            libraryItems.Add(new Book(2, "The Great Gatsby, 1925, F. Scott Fitzgerald, Tragedy"));
            libraryItems.Add(new Book(3, "The Hobbit, 1937, J.R.R. Tolkien, Fantasy"));
           
            libraryItems.Add(new DVD(1, "The Godfather, 1972, Francis Ford Coppola, 175 minutes"));
            libraryItems.Add(new DVD(2, "The Dark Knight, 2008, Christopher Nolan, 152 minutes"));
            libraryItems.Add(new DVD(3, "The Matrix, 1999, The Wachowskis, 136 minutes"));
           
            libraryItems.Add(new Magazine(1, "National Geographic, 2023, Issue 4, April"));
            libraryItems.Add(new Magazine(2, "Forbes, 2023, Issue 6, June"));
            libraryItems.Add(new Magazine(3, "The Economist, 2023, Issue 10, October"));


            while (true)







        }
    }
}
