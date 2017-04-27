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

						Abilitys[0] = new Ability.Ability(xlbook.Worksheet(1).Cell(row, 12).Value.ToString());
						Abilitys[1] = new Ability.Ability(xlbook.Worksheet(1).Cell(row, 13).Value.ToString());
						Abilitys[2] = new Ability.Ability(xlbook.Worksheet(1).Cell(row, 14).Value.ToString());
				}
				StatusManager.Status St;
				int[] BaseSt = new int[6];
				Ability.Ability[] Abilitys = new Ability.Ability[3]; 
				Base.Property Show = new Base.Property();
		}
}

