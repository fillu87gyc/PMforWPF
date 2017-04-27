using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManage
{
		public class Pokemon
		{
				public Pokemon(string NameArg)
				{
						var xlbook = new ClosedXML.Excel.XLWorkbook(Base.Preparation.DATABASE + "Name.xlsx");
						int counter = 0;
						while (NameArg != (xlbook.Worksheet(1).Cell(counter, 1).Value.ToString()))
						{
								counter++;
						}
						var row = counter;
						for (int i = 0; i < 6; i++)
						{
								BaseSt[i] = int.Parse(xlbook.Worksheet(1).Cell(row, i + 3).Value.ToString());
						}

						Show.ImgType1 = xlbook.Worksheet(1).Cell(row, 10).Value.ToString();
						Show.ImgType2 = xlbook.Worksheet(1).Cell(row, 11).Value.ToString();
						for (int i = 0; i < 3; i++)
						{
								Abilitys[i] = new Ability.Ability(xlbook.Worksheet(1).Cell(row, 12+i).Value.ToString());
						}
				}

				StatusManager.Status St;
				int[] BaseSt = new int[6];
				Ability.Ability[] Abilitys = new Ability.Ability[3];
				Base.Property Show = new Base.Property();
		}
}