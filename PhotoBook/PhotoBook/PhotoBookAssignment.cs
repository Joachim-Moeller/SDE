namespace PhotoBook;

public class PhotoBook
{
    protected int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        this.numPages = numPages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook()
    {
        numPages = 64;
    }
}

public class OwnPhotoBook : PhotoBook
{
    public OwnPhotoBook()
    {
        Console.Write("Input number of pages in my own photo book: ");
        numPages = Convert.ToInt32(Console.ReadLine());
    }
}

internal class PhotoBookAssignment
{
    public static void Main()
    {
        var myOwnPhotoBook = new OwnPhotoBook();
        Console.WriteLine("-------------------------------------------------------");
        Console.Write("Number of pages in my own photo book is ", myOwnPhotoBook);
        Console.WriteLine(myOwnPhotoBook.GetNumberPages());

        var myPhotoBook1 = new PhotoBook();
        Console.Write("Number of pages in default sized photo book is ", myPhotoBook1);
        Console.WriteLine(myPhotoBook1.GetNumberPages());

        var myPhotoBook2 = new PhotoBook(24);
        Console.Write("Number of pages in larger sized photo book is ", myPhotoBook2);
        Console.WriteLine(myPhotoBook2.GetNumberPages());

        var myBigPhotoBook = new BigPhotoBook();
        Console.Write("Number of pages in the big photo book is ", myBigPhotoBook);
        Console.WriteLine(myBigPhotoBook.GetNumberPages());
    }
}