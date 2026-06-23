
using System;


class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;


    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}


class Program
{


    static Product LinearSearch(Product[] products,string name)
    {

        for(int i=0;i<products.Length;i++)
        {
            if(products[i].ProductName==name)
            {
                return products[i];
            }
        }

        return null;

    }



    static Product BinarySearch(Product[] products,string name)
    {

        int start=0;
        int end=products.Length-1;


        while(start<=end)
        {

            int mid=(start+end)/2;


            if(products[mid].ProductName==name)
            {
                return products[mid];
            }


            if(products[mid].ProductName.CompareTo(name)<0)
            {
                start=mid+1;
            }

            else
            {
                end=mid-1;
            }

        }


        return null;

    }



    static void Main()
    {


        Product[] products =
        {

            new Product(1,"Laptop","Electronics"),
            new Product(2,"Mobile","Electronics"),
            new Product(3,"Shoes","Fashion"),
            new Product(4,"Tablet","Electronics"),
            new Product(5,"Watch","Fashion")

        };



        Console.WriteLine("Linear Search:");

        Product p1=LinearSearch(products,"Shoes");


        Console.WriteLine(
        p1.ProductId+" "+
        p1.ProductName+" "+
        p1.Category);



        Console.WriteLine();



        Array.Sort(products,(x,y)=>x.ProductName.CompareTo(y.ProductName));



        Console.WriteLine("Binary Search:");

        Product p2=BinarySearch(products,"Tablet");


        Console.WriteLine(
        p2.ProductId+" "+
        p2.ProductName+" "+
        p2.Category);



        Console.WriteLine();



        Console.WriteLine("Linear Search Complexity: O(n)");

        Console.WriteLine("Binary Search Complexity: O(log n)");

        Console.WriteLine("Binary Search is better for large e-commerce databases.");

    }

}