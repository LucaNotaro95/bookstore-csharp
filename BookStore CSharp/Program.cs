//Bookstore

string printAuthor(string[] authors)
{
    string result = "";

    foreach (string author in authors)
    {
        result = result + " " + author;
    }
    return result;
}

string title = "Clean Code: A Handbook of Agile Software Craftsmanship";
string[] authors = {"Robert C. Martin" , "Dean Wampler"};
long ISBN = 9780132350884;
int nPages = 431;
double weight = 0.660;
double height = 23.5;
double widht = 17.91;
double depth = 2.54;
double averageRating = 4.7;
int nReviews = 3308;
bool isKindle = true;
bool isCoverFlexible = true;

Console.WriteLine("——— IL LIBRO DI OGGI: " +title+" di " +printAuthor(authors)+ " ——————-" +
    "\nISBN: " + ISBN +
    "\nNumero delle pagine: " + nPages +"pagine" +
    "\nPeso del libro: "+ weight + "kg" +
    "\nDimensioni del libro: " + widht + "cm x "+ height + "cm x " + depth +" cm" +
    "\nInformazioni Amazon: " +
    "\nNumero di recensioni: " + nReviews+ " recensioni" +
    "\nValutazione media: " + averageRating + " stelline" +
    "\nKindle disponibile: " + ( isKindle ? "Si" : "No" ) +
    "\nCopertina flessibile disponibile: " + (isCoverFlexible ? "Si" : "No") );