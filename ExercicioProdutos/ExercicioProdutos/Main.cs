using System;

namespace ExercicioProdutos {
    class Launch {
        static void Main() {
            ProductEntity product;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            product = new ProductEntity(name, price, quantity);

            double total = product.TotalStoredValue();

            Console.WriteLine($"Dados do produto: {product.name}, {product.quantity} unidades, Total: {total}");
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque");
            int addQuantity = int.Parse(Console.ReadLine());
            product.AddProducts(addQuantity);
            total = product.TotalStoredValue();

            Console.WriteLine($"Dados atualizados: {product.name}, {product.quantity} unidades, Total: {total}");
            Console.WriteLine("Digite o número de produtos a ser removido do estoque");
            int removeQuantity = int.Parse(Console.ReadLine());
            product.RemoveProducts(removeQuantity);
            total = product.TotalStoredValue();
            Console.WriteLine($"Dados atualizados: {product.name}, {product.quantity} unidades, Total: {total}");
        }

    }
}
