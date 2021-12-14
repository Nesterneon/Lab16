using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Lab16
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Product product1 = new Product();
            product1.code = Convert.ToInt32(Console.ReadLine());
            product1.name= Console.ReadLine();
            product1.price = Convert.ToInt32(Console.ReadLine());
            MyClass mc1 = new MyClass();
            mc1.Prod = product1;

            Product product2 = new Product();
            product2.code = Convert.ToInt32(Console.ReadLine());
            product2.name = Console.ReadLine();
            product2.price = Convert.ToInt32(Console.ReadLine());
            MyClass mc2 = new MyClass();
            mc2.Prod = product2;

            Product product3 = new Product();
            product3.code = Convert.ToInt32(Console.ReadLine());
            product3.name = Console.ReadLine();
            product3.price = Convert.ToInt32(Console.ReadLine());
            MyClass mc3 = new MyClass();
            mc3.Prod = product3;

            Product product4 = new Product();
            product4.code = Convert.ToInt32(Console.ReadLine());
            product4.name = Console.ReadLine();
            product4.price = Convert.ToInt32(Console.ReadLine());
            MyClass mc4 = new MyClass();
            mc4.Prod = product4;

            Product product5 = new Product();
            product5.code = Convert.ToInt32(Console.ReadLine());
            product5.name = Console.ReadLine();
            product5.price = Convert.ToInt32(Console.ReadLine());
            MyClass mc5 = new MyClass();
            mc5.Prod = product5;

            MyClass[] mcar = new MyClass[5];
            mcar[0] = mc1;
            mcar[1] = mc2;
            mcar[2] = mc3;
            mcar[3] = mc4;
            mcar[4] = mc5;

            string json = JsonSerializer.Serialize<MyClass[]>(mcar);
            Console.WriteLine(json);
            StreamWriter file = new StreamWriter("Products.json");
            file.WriteLine(json);
            file.Close();

            //чтение из файла
            using (FileStream fs = new FileStream("Product.json", FileMode.OpenOrCreate))
            {
                MyClass restoredMyClass = await JsonSerializer.DeserializeAsync<MyClass>(fs);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    public class Product
    {
        public int code { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
    public class MyClass
    {
        public Product Prod { get; set; }
    }
}
