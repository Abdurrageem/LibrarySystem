

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding the Items into the library.
            List<LibraryItem> libraryItems = new List<LibraryItem>();
            libraryItems.Add(new Book(1, "To Kill a Mockingbird", " 1960", "Harper Lee", "Fiction"));
            libraryItems.Add(new Book(2, "The Great Gatsby", "1925", "F. Scott Fitzgerald", "Tragedy"));
            libraryItems.Add(new Book(3, "The Hobbit", "1937", "J.R.R. Tolkien", "Fantasy"));

            libraryItems.Add(new DVD(1, "The Godfather", "1972", "Francis Ford Coppola", "175 minutes"));
            libraryItems.Add(new DVD(2, "The Dark Knight", "2008", "Christopher Nolan", "152 minutes"));
            libraryItems.Add(new DVD(3, "The Matrix", "1999", "The Wachowskis", "136 minutes"));

            libraryItems.Add(new Magazine(1, "National Geographic", "2023", "Issue 4", "April"));
            libraryItems.Add(new Magazine(2, "Forbes", "2023", "Issue 6", "June"));
            libraryItems.Add(new Magazine(3, "The Economist", "2023", "Issue 10", "October"));


            while (true)
            {
                Console.Write("Welcome to my LibrarySystem");
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Add an Item");
                Console.WriteLine("2. Display Items");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. Remove Item");
                Console.WriteLine("5. Exit");


                var NumberChosen = Console.ReadLine();

                switch (NumberChosen)
                {
                    //Selecting an item to add to the list
                    case "1":
                        Console.WriteLine("\nWould you like to: ");
                        Console.WriteLine("1. Add a book");
                        Console.WriteLine("2. Add a Magazine");
                        Console.WriteLine("3. Add a DVD");
                        Console.WriteLine("4. Return");
                        NumberChosen = Console.ReadLine();

                        switch (NumberChosen)
                        {
                            //Adding a Book
                            case "1":
                                Console.Write("\nWhat is the name of the book? ");
                                string BookName = Console.ReadLine();

                                Console.Write("\nWho is the author of the book? ");
                                string BookAuthor = Console.ReadLine();

                                Console.Write("\nWhat is the ID of the book? ");
                                string BookID = Console.ReadLine();
                                int intID = Int32.Parse(BookID);

                                Console.Write("\nWhat is the genre of the book? ");
                                string BookGenre = Console.ReadLine();

                                Console.Write("\nWhat year was the book Published? ");
                                string BookYear = Console.ReadLine();


                                Book Books = new Book(intID, BookName, BookYear, BookAuthor, BookGenre);
                                libraryItems.Add(Books);
                                break;

                            //Adding a Magazine
                            case "2":
                                Console.Write("\nWhat is the name of the Magazine? ");
                                string magazineName = Console.ReadLine();

                                Console.Write("\nWhat is the issue number of the Magaine? ");
                                string issueNumber = Console.ReadLine();
                                

                                Console.Write("\nWhat is the ID of the Magazine? ");
                                string MagazineID = Console.ReadLine();
                                int magID = Int32.Parse(MagazineID);

                                Console.Write("\nWhat month was the Magazine published? ");
                                string month = Console.ReadLine();

                                Console.Write("\nWhat year was the Magazine published? ");
                                string yearPublished = Console.ReadLine();


                                Magazine Magazine = new Magazine(magID, magazineName, yearPublished, issueNumber, month);
                                libraryItems.Add(Magazine);
                                break;

                            //Adding a DVD
                            case "3":
                                Console.Write("\nWhat is the name of the DVD? ");
                                string DVDName = Console.ReadLine();

                                Console.Write("\nWho is the Director? ");
                                string director = Console.ReadLine();

                                Console.Write("\nWhat is the ID of the DVD? ");
                                string dvdID = Console.ReadLine();
                                int intDvdID = Int32.Parse(dvdID);

                                Console.Write("\nWhat is the Duration of the movie? ");
                                string duration = Console.ReadLine();

                                Console.Write("\nWhat year was the Movie created? ");
                                yearPublished = Console.ReadLine();


                                DVD Dvd = new DVD(intDvdID, DVDName, yearPublished, director, duration);
                                libraryItems.Add(Dvd);
                                break;

                            //Return to Menu
                            case "4":
                                break;
                        }
                        break;

                            //Display an item
                            case "2":

                        Console.WriteLine("Would you like to display: ");
                        Console.WriteLine("1. All Books");
                        Console.WriteLine("2. All Magaines");
                        Console.WriteLine("3. All DVDs");
                        Console.WriteLine("4. Return");
                        NumberChosen = Console.ReadLine();

                        
                        switch (NumberChosen)
                        {
                            //Displayiing Books
                            case "1":
                                foreach (var item in libraryItems.OfType<Book>())
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            //Displaying Magazines
                            case "2":
                                foreach (var item in libraryItems.OfType<Magazine>())
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            //Displaying DVDs
                            case "3":
                                foreach (var item in libraryItems.OfType<DVD>())
                                {
                                    Console.WriteLine(item);
                                }
                                break;
                            //Return
                            case "4":
                                break;

                        }
                        break;

                    //Finding an Item
                    case "3":

                        Console.WriteLine("Would you like to find: ");
                        Console.WriteLine("1. A Book");
                        Console.WriteLine("2. A Magaine");
                        Console.WriteLine("3. A DVD");
                        Console.WriteLine("4. Return");
                        NumberChosen = Console.ReadLine();
                       
                       switch (NumberChosen)
                        {
                            case "1":
                                Console.Write("\nEnter the ID of the item you would like to search : ");
                                int IDSearch = Int32.Parse(Console.ReadLine());
                                LibraryItem bookSearch = libraryItems.OfType<Book>().FirstOrDefault(item => item.Id == IDSearch);

                                if (bookSearch != null)
                                {
                                    Console.WriteLine("Item found!");
                                    Console.WriteLine(bookSearch);
                                }
                                break;
                            case "2":
                                Console.Write("\nEnter the ID of the item you would like to search : ");
                                IDSearch = Int32.Parse(Console.ReadLine());
                                LibraryItem magazineSearch = libraryItems.OfType<Magazine>().FirstOrDefault(item => item.Id == IDSearch);

                                if (magazineSearch != null)
                                {
                                    Console.WriteLine("Item found!");
                                    Console.WriteLine(magazineSearch);
                                }
                                break;
                            case "3":
                                Console.Write("\nEnter the ID of the item you would like to search : ");
                                IDSearch = Int32.Parse(Console.ReadLine());
                                LibraryItem dvdSearch = libraryItems.OfType<DVD>().FirstOrDefault(item => item.Id == IDSearch);

                                if (dvdSearch != null)
                                {
                                    Console.WriteLine("Item found!");
                                    Console.WriteLine(dvdSearch);
                                }
                                break;
                            case "4":
                                break;
                        }
                        break;

                    //Removing an item
                    case "4":
                        Console.WriteLine("Would you like to rmove: ");
                        Console.WriteLine("1. A Book");
                        Console.WriteLine("2. A Magaine");
                        Console.WriteLine("3. A DVD");
                        Console.WriteLine("4. Return");
                        NumberChosen = Console.ReadLine();

                        switch(NumberChosen)
                        {
                            case "1":
                                Console.Write("\nEnter the ID of the Book you would like to remove : ");
                                int IDRemove = Int32.Parse(Console.ReadLine());
                                LibraryItem itemRemove = libraryItems.OfType<Book>().FirstOrDefault(item => item.Id == IDRemove);

                                if (itemRemove != null)
                                {
                                    libraryItems.Remove(itemRemove);
                                    Console.WriteLine("Item was removed!");
                                }
                                break;
                            case "2":
                                Console.Write("\nEnter the ID of the Magazine you would like to remove : ");
                                IDRemove = Int32.Parse(Console.ReadLine());
                                itemRemove = libraryItems.OfType<Magazine>().FirstOrDefault(item => item.Id == IDRemove);

                                if (itemRemove != null)
                                {
                                    libraryItems.Remove(itemRemove);
                                    Console.WriteLine("Item was removed successfully!");
                                }
                                break;
                            case "3":
                                Console.Write("\nEnter the ID of the DVD you would like to remove : ");
                                IDRemove = Int32.Parse(Console.ReadLine());
                                itemRemove = libraryItems.OfType<DVD>().FirstOrDefault(item => item.Id == IDRemove);

                                if (itemRemove != null)
                                {
                                    libraryItems.Remove(itemRemove);
                                    Console.WriteLine("Item was removed!");
                                }
                                break;
                            case "4":
                                break;
                        }
                        break;
                    //Exiting Program
                    case "5":
                        return;
                }

            }





















        }







    }
}

