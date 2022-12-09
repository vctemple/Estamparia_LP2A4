using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estamparia_LP2A4.Objetos_Estamp
{
    internal class Item_Carrinho
    {
        private int _idProd;
        private int _qtdItem;

        public Item_Carrinho(int idProd, int qtdItem)
        {
            _idProd = idProd;
            _qtdItem = qtdItem;
        }

        public int IdProd { get { return _idProd; } }
        public int qtdItem { get { return _qtdItem; } }
    }
}
