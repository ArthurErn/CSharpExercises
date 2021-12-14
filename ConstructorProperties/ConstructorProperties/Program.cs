namespace Course {
    class Produto {
        private string _nome;
        private readonly double _preco;
        private read9ohint _quantidade;

        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        public double Preco {
            get { return _preco; }
        }
        public int Quantidade {
            get { return _quantidade; }
        }
    }
}