using LibraryService.Models;

Console.WriteLine("Starting Program...");
Console.WriteLine("Instancing classes..." + "\n");

//Instantiating a list of books
var books = new List<Book>();
var booksMachadoAssis = new List<Book>();
var booksJorgeAmado = new List<Book>();

//Instantiating the category class
var romance = new Category(1, "Romance", "The novel is a narrative literary form written in prose that became popular in " +
    "Western literature during the 19th century.");
var fiction = new Category(2, "Fiction", "Fiction books are those that tell an imagined story, without necessarily having anything to do with reality");

//Instantiating the author class
var machadoAssis = new Author(1, "Joaquim Maria Machado de Assis", booksMachadoAssis, "Joaquim Maria Machado de Assis was a Brazilian writer, considered by many critics, scholars, writers and " +
    "readers the greatest name in Brazilian literature.");
var jorgeAmado = new Author(2, "Jorge Amado", booksJorgeAmado, "Jorge Amado was one of the most famous and translated Brazilian writers of all time," +
    " being the author most adapted for film, theater and television.");

//Instantiating the book class
var domCasmurro = new Book(
    1,
    "Dom Casmurro",
    "Dom Casmurro tells the story of Bento Santiago (Bentinho), nicknamed Dom Casmurro for being quiet and introverted. " +
    "As a teenager, he falls in love with Capítu, abandoning the seminary and, with him, the plans laid down by his mother, Dona Glória, " +
    "so that he could become a priest.",
    machadoAssis,
    romance,
    true
    );

var brasCubas = new Book(
    2,
    "Memórias Póstumas de Brás Cubas",
    "After his death in 1869, Brás Cubas decides to narrate his story and revisit the most important events of his life in order to distract himself " +
    "in eternity. From then on, he remembers friends like Quincas Borba, his lackluster academic education in Portugal, the loves of his life and the " +
    "privilege he had of never having had to work in his life.",
    machadoAssis,
    romance,
    true
    );

var capitaesDaAreia = new Book(
    3,
    "Capitães da Areia",
    "Pedro Bala, Professor, Gato, Sem Pernas and Boa Vida are teenagers abandoned by their families, who grow up on the streets of Salvador and live in a " +
    "community in Trapiche. They commit a series of robberies and are constantly pursued by the police. One day, Professor meets Dora and her brother " +
    "Zé Fuinha and takes them to the Trapiche, which excites the other boys, who are not used to the presence of a woman there. Little by little, " +
    "affection develops between the leader of the group and the young girl.",
    jorgeAmado,
    fiction,
    true
    );

var marMorto = new Book(
    4,
    "Mar Morto",
    "The life of sailors on the docks of Salvador, with its rich mythology revolving around Iemanjá, is the central theme of Mar morto, " +
    "a lyrical and tragic panel about the daily struggle of these workers for survival.",
    jorgeAmado,
    fiction,
    true
    );

Console.WriteLine("Adding books to the list" + "\n");
books.Add(domCasmurro);
books.Add(brasCubas);
books.Add(capitaesDaAreia);
books.Add(marMorto);

Console.WriteLine("Displaying book lists with foreach" + "\n");
foreach (var book in books)
{
    //Here we will associate the book with its author according to the author field of the book class
    if (book.author.name == "Joaquim Maria Machado de Assis")
    {
        booksMachadoAssis.Add(book);
    }
    else if (book.author.name == "Jorge Amado")
    {
        booksJorgeAmado.Add(book);
    }

    Console.WriteLine("id: " + book.id);
    Console.WriteLine("name: " + book.name);
    Console.WriteLine("description: " + book.description);
    Console.WriteLine("author: " + book.author.name);
    Console.WriteLine("category: " + book.category.name);
    Console.WriteLine("available: " + (book.available ? "Disponível" : "Não disponível") + "\n");
}

//Here we offer the user to add an author from the creation of the person to the author data itself
static void createAndPrintAuthor(Book book1, Book book2)
{
    Console.WriteLine("Let's add a new author to our platform (if you want, you can invent it)" + "\n");

    int authorId = 1;

    Console.WriteLine("Enter the Author's name:");
    string authorName = Console.ReadLine();

    Console.WriteLine("Enter the Author's date of birth (Use dd/MM/yyyy format):");
    DateTime authorBirth = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Enter the author's CPF:");
    string authorCpf = Console.ReadLine();

    Console.WriteLine("Enter the author's email:");
    string authorEmail = Console.ReadLine();

    Console.WriteLine("Enter the author's phone number:");
    string authorPhone = Console.ReadLine();

    Console.WriteLine("Enter author biography:");
    string authorBiography = Console.ReadLine();

    var authorBooks = new List<Book>();
    authorBooks.Add(book1);
    authorBooks.Add(book2);

    var person = new Person(authorId, authorName, authorBirth, authorCpf, authorEmail, authorPhone);

    Author author = new Author(person.id, person.name, person.birth, person.cpf, person.email, person.phone, authorId, authorBooks, authorBiography);

    Console.WriteLine($"ID: {author.id}");
    Console.WriteLine($"Name: {author.name}");
    Console.WriteLine($"Birth: {author.birth}");
    Console.WriteLine($"CPF: {author.cpf}");
    Console.WriteLine($"Email: {author.email}");
    Console.WriteLine($"Phone: {author.phone}");
    Console.WriteLine($"Biography: {author.biography}");
    Console.WriteLine("Books:");

    foreach (var book in author.books)
    {
        Console.WriteLine($"- Name: {book.name}, Description: {book.description}, Category: {book.category.name}" + "\n");
    }
}

//Here is the call to the method that we created
createAndPrintAuthor(brasCubas, capitaesDaAreia);

Console.WriteLine("\n" + "Carrying out the rental of books");
//Here we will carry out the rental of books in each unit listed
Address address = new Address(1, "Paulista - Consolação", "São Paulo", "SP", "Brasil", "12345-000", "Andar 2");

DateTime initialDate = DateTime.Now;
DateTime returnDate = initialDate.AddDays(30);
decimal rentalAmount = 100m;

//Instantiating of Paulista Unit
Rental rentalPaulista = new Paulista(1, initialDate, returnDate, domCasmurro, rentalAmount);

//Instantiating of Vila Olimpia Unit
Rental rentalVilaOlimpia = new VilaOlimpia()
{
    id = 2,
    initialRentalDate = initialDate,
    returnDate = returnDate,
    book = marMorto,
    rentalAmount = rentalAmount
};

//Instantiating of Aclimacao Unit
Rental rentalAclimacao = new Aclimacao()
{
    id = 3,
    initialRentalDate = initialDate,
    returnDate = returnDate,
    book = capitaesDaAreia,
    rentalAmount = rentalAmount
};

Console.WriteLine("Doing reservations");
Console.WriteLine(rentalPaulista.bookReservation());
Console.WriteLine(rentalVilaOlimpia.bookReservation());
Console.WriteLine(rentalAclimacao.bookReservation());

//Instantiating another list of books
List<Book> paulistaBooks = new List<Book>() { marMorto, capitaesDaAreia, domCasmurro };

//Instantiating a new Unit to console for us
Unit unit = new Unit(1, "Paulista Shopping", paulistaBooks, address, rentalPaulista);

Console.WriteLine($"Unit: {unit.name}, Address: {unit.address.city}, Books: {unit.books.Count}, Rental: {unit.rental.bookReservation()}" + "\n");

Console.WriteLine("“Faça o teu melhor, na condição que você tem, enquanto você não tem condições melhores, para fazer melhor ainda”" + "\nMario Sergio Cortela");