namespace CSharpApp_7
{
    public class Program
    {
        static void Main()
        {
            Book electronicBook = new ElectronicBook("Design Patterns", "Gang of Four");
            IBookStore onlineBookStore = new OnlineBookStore();
            onlineBookStore.DisplayBookDetails(electronicBook);

            Book printedBook = new PrintedBook("Clean Code", "Robert C. Martin");
            IBookStore physicalBookStore = new PhysicalBookStore();
            physicalBookStore.DisplayBookDetails(printedBook);
        }
    }
}
