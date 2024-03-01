using LibraryService.Models;

Console.WriteLine("Starting Program...");
Console.WriteLine("Instancing classes" + "\n");

Console.WriteLine("Instantiating a list of books" + "\n");
var books = new List<Book>();

var booksMachadoAssis = new List<Book>();
var booksJorgeAmado = new List<Book>();

Console.WriteLine("Instantiating the category class" + "\n");
var romance = new Category(1, "Romance", "The novel is a narrative literary form written in prose that became popular in " +
    "Western literature during the 19th century.");
var fiction = new Category(2, "Fiction", "Fiction books are those that tell an imagined story, without necessarily having anything to do with reality");

Console.WriteLine("Instantiating the author class" + "\n");
var machadoAssis = new Author(1, "Joaquim Maria Machado de Assis", booksMachadoAssis, "Joaquim Maria Machado de Assis was a Brazilian writer, considered by many critics, scholars, writers and " +
    "readers the greatest name in Brazilian literature.");
var jorgeAmado = new Author(2, "Jorge Amado", booksJorgeAmado, "Jorge Amado was one of the most famous and translated Brazilian writers of all time," +
    " being the author most adapted for film, theater and television.");

Console.WriteLine("Instantiating the book class" + "\n");
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
    if (book.author.name == "Joaquim Maria Machado de Assis") {
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

var rental = new Rental
{
    
};

var address = new Address
{

};

var person = new Person
{
    id = 1,
    name = "Test",
    birth = DateTime.Now,
    address = address,
    cpf = "",
    email = "Test",
    phone = "Test",
};

var unit = new Unit
{
    id = 1,
    name = string.Empty,
    address = address,
    books = books,
    rental = rental
};