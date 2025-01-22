

using _02.Library;
        var book1 = new Book("1984", "Джордж Оруел", "123456789");
        var book2 = new Book("Мобі Дик", "Херман Мелвил", "987654321");

        var library = new Library();

        library.AddBook(book1);
        library.AddBook(book2);

        var reader = new Reader("Иван Иванов", "001", "ivan@example.com");

        library.AddReader(reader);

        reader.CheckOutBook(book1);

        reader.CheckOutBook(book2);

        library.GetBooksStatus();

        reader.ReturnBook(book1);

        library.GetBooksStatus();
