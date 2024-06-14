using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
	public class Product
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string ProductId { get; set; }

        public string ProductName { get; set; }  // Ürünün Adı

		public decimal ProductPrice { get; set; }  // Ürünün Fiyatı

		public string ProductImageUrl { get; set; } // Ürünün Resmi

        public string ProductDescription { get; set; } // Ürün Açıklaması

        public string CategoryId { get; set; }
        [BsonIgnore]
        public Category Category { get; set; }


    }
}
