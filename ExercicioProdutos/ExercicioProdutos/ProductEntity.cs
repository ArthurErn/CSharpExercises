using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProdutos {
    class ProductEntity {
        public string name;
        public double price;
        public int quantity;

        public ProductEntity(string name, double price, int quantity) {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double TotalStoredValue() {
            return price * quantity;
        }

        public void AddProducts(int parameter) {
            quantity += parameter;
        }

        public void RemoveProducts(int parameter) {
            quantity -= parameter;
        }
    }
}
