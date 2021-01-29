using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ Id=1, Name="Saat X", ImageUrl="https://cdn.dsmcdn.com//ty4/product/media/images/20200515/20/1346923/16483087/2/2_org.jpg", Description="Kol Saati", Price=139.90M, Discount=0.55, Rating=4.2},
                new Product{ Id=2, Name="Saat Y", ImageUrl="https://cdn.dsmcdn.com//ty4/product/media/images/20200515/20/1346923/57592550/2/2_org.jpg",Description="Kadın Kol Saati", Price=139.90M, Discount=0.55, Rating=4.2},
                new Product{ Id=3, Name="cüzdan", ImageUrl="https://cdn.dsmcdn.com//Assets/ProductImages/oa/97/3865369/3/8680869795488_k_org.jpg",Description="test", Price=139.90M, Discount=0.55, Rating=4.2},
                new Product{ Id=4, Name="Çanta", ImageUrl="https://cdn.dsmcdn.com//ty51/product/media/images/20210109/4/49931442/96996859/1/1_org.jpg",Description="test3", Price=139.90M, Discount=0.55, Rating=4.2},
                new Product{ Id=5, Name="Pantolon", ImageUrl="https://cdn.dsmcdn.com//assets/product/media/images/20200323/9/4639291/66134216/1/1_org.jpg",Description="test2", Price=139.90M, Discount=0.55, Rating=4.2},
                new Product{ Id=6, Name="Lamba", ImageUrl="https://cdn.dsmcdn.com//ty51/product/media/images/20210109/1/49644613/83140030/1/1_org.jpg",Description="Deneme", Price=139.90M, Discount=0.55, Rating=4.2},
            };
        }
    }
}
