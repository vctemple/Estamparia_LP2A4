using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estamparia_LP2A4.Objetos_Estamp
{
    internal class Produtos
    {
        private int _id;
        private string _marca;
        private string _estampa;
        private int _qtd_estoque;
        private decimal _preco;
        private string _tam;
        private string _cor;
        private string _img1End;
        private string _img2End;

        // Criando Produto
        public Produtos(string marca, string estampa, int qtd_estoque, decimal preco, string tam, string cor, string img1End, string img2End)
        {
            _marca = marca;
            _estampa = estampa;
            _qtd_estoque = qtd_estoque;
            _preco = preco;
            _tam = tam;
            _cor = cor;
            _img1End = img1End;
            _img2End = img2End;
        }

        // Listando Produto no estoque ou na compra
        public Produtos(int id, string marca, string estampa, int qtd_estoque, decimal preco, string tam, string cor, string img1End, string img2End):
            this(marca, estampa, qtd_estoque, preco, tam, cor, img1End, img2End)
        {
            _id = id;
        }

        public int Id {get { return _id; } }
        public string Marca { get { return _marca; }  }
        public string Estampa { get { return _estampa; } }
        public int Qtd_estoque { get { return _qtd_estoque; } }
        public decimal Preco { get { return _preco; } }
        public string Tam { get { return _tam; } }
        public string Cor { get { return _cor; } }
        public string Img1 { get { return _img1End; } }
        public string Img2 { get { return _img2End; } }
    }
}
