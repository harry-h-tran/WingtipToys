using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WingtipToys.Models;

namespace WingtipToys.Logic
{
	public class ShoppingCartActions : IDisposable
	{
		public string ShoppingCartId { get; set; }

		private ProductContext _db = new ProductContext();

		public const string CartSessionKey = "CartId";

		public void AddToCart(int id)
		{
			// Retrieve Product from db
			ShoppingCartId = GetCartId();

			var cartItem = _db.ShoppingCartItems.SingleOrDefault(
				c => c.CartId == ShoppingCartId
				&& c.ProductId == id);

			if (cartItem == null)
			{

			}
		}
	}
}