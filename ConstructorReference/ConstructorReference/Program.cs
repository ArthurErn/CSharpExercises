namespace ConstructorReference {
    class ProductEntity {
        public string name;
        public double price;
        public int quantity;

        //Default constructor, passing the value to the attribute
        public ProductEntity() {
            quantity = 0;
        }

        //overcharged constructor referencing default constructor with "this()"
        public ProductEntity(string name, double price) : this() {
            this.name = name;
            this.price = price;
        }

        //overcharged constructor referencing another to reply it's values
        public ProductEntity(string name, double price, int quantity): this(name, price) {
            this.quantity = quantity;
        }
    }
}
