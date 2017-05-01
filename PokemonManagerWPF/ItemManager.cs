using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item
{
		using ClosedXML.Excel;
		class ItemManager
		{
				public ItemManager()
				{
						for (int i = 0; i < Base.Preparation.ITEM; i++)
						{
								items[i] = new Item(i + 1);
								Names[i] = items[i].Name;
						}
						Plates =
								from data in items
								where data.Tags == "プレート"
								select data.Name;
						Jewels =
								 from data in items
								 where data.Tags == "ジュエル"
								 select data.Name;
						Crystals = from data in items
								   where data.Tags == "Zクリスタル"
								   select data.Name;
						Berries = from data in items
								  where data.Tags == "きのみ"
								  select data.Name;
						Designated = from data in items
									 where data.HaveAbleMember[0] != "ALL"
									 select data.Name;
						Others_use = from data in items
									 where data.Tags == "対戦その他"
									 select data.Name;
						Others_no = from data in items
									where data.Tags == "その他"
									select data.Name;
				}
				public string[] Names;
				public IEnumerable<string> Plates;
				public IEnumerable<string> Jewels;
				public IEnumerable<string> Crystals;
				public IEnumerable<string> Berries;
				public IEnumerable<string> Designated;
				public IEnumerable<string> Others_use;
				public IEnumerable<string> Others_no;
				Item[] items = new Item[Base.Preparation.ITEM];
		}
		class Item
		{
				public Item(int row)
				{
						name = book.Worksheet(1).Cell(row, 1).Value.ToString();
						effect = book.Worksheet(1).Cell(row, 2).Value.ToString();
						haveAble = book.Worksheet(1).Cell(row, 3).Value.ToString();
						description = book.Worksheet(1).Cell(row, 4).Value.ToString();
				}
				XLWorkbook book = new XLWorkbook(Base.Preparation.DATABASE + "Item.xlsx");
				public string Name
				{
						get
						{
								return name;
						}
				}
				public string[] Effect
				{
						get
						{
								return effect.Split('\\');
						}
				}
				public string[] HaveAbleMember
				{
						get
						{
								return haveAble.Split(',');
						}
				}
				public string Tags
				{
						get
						{
								return tags;
						}
				}
				public string Description
				{
						get
						{
								return description;
						}
				}
				string name;
				string effect;
				string haveAble;
				string tags;
				string description;
		}
}
