using System;
namespace BookStoreApi.Models
{//appsettings.json da tanımladıklarımızı buraya birdaha yazıyoruz.
	public class BookStoreDatabaseSettings
	{
		public string ConnectionString { get; set; } = null!;
		public string DatabaseName { get; set; } = null!;
		public string BooksCollectionName { get; set; } = null!; 

	}
}

