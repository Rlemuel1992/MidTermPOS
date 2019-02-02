using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
	class Reciept
	{
		int quantity = 0;
		string itemName = "";
		float itemPrice = 0.0f;
		int multipleItems;

		public Reciept(int Q, string N, float P)
		{
			this.quantity = Q;
			this.itemName = N;
			this.itemPrice = P;
		}
		public int Quantity
		{
			get { return quantity; }
		}
		public string ItemName
		{
			get { return itemName; }
		}
		public float ItemPrice
		{
			get { return itemPrice; }
		}
		public void PrintReceipt()
		{
			Console.WriteLine("");
		}
	}
}