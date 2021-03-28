using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Product product = new Product("pokemon", 100);
            client.calcProductPrice(product);

            Box smallBox1 = new Box();
            smallBox1.add(new Product("iphone", 9));
            smallBox1.add(new Product("ipad", 5));

            Box smallBox2 = new Box();
            smallBox2.add(new Product("android", 10));

            Box complexBox = new Box();
            complexBox.add(smallBox1);
            complexBox.add(smallBox2);
            complexBox.add(product);

            client.calcTotalPrice(complexBox);
        }
    }
}
