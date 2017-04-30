using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
		using System.ComponentModel;
		public class Notify : INotifyPropertyChanged
		{
				public event PropertyChangedEventHandler PropertyChanged;
				public void NotifyPropertyChanged(String info)
				{
						PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
				}
		}

		/// <summary>
		/// 表示画面で用いられるプロパティ一覧
		/// </summary>
		public class Property : Notify
		{
				public string Name
				{
						get { return name; }
						set
						{
								name = value;
								NotifyPropertyChanged("Name");
						}
				}
				public string ImgSource
				{
						get { return imgsource; }
						set
						{
								imgsource = value;
								NotifyPropertyChanged("ImgSource");
						}
				}
				public string ImgType1
				{
						get { return imgType1; }
						set
						{
								imgType1 = value;
								NotifyPropertyChanged("ImgType1");
						}
				}
				public string ImgType2
				{
						get { return imgType2; }
						set
						{
								imgType2 = value;
								NotifyPropertyChanged("ImgType2");
						}
				}
				public StatusManager.Status StatusMgr
				{
						get { return statusmgr; }
						set
						{
								statusmgr = value;
								NotifyPropertyChanged("StatusMgr");
						}
				}
				public string Ability
				{
						get { return ability; }
						set
						{
								ability = value;
								NotifyPropertyChanged("Ability");
						}
				}
				public string Tokusei
				{
						get { return tokusei; }
						set
						{
								tokusei = value;
								NotifyPropertyChanged("Tokusei");
						}
				}
				protected string name = "No";
				protected string imgsource = "";
				protected string imgType1 = "";
				protected string imgType2 = "";
				protected StatusManager.Status statusmgr = new StatusManager.Status();
				protected string ability = "";
				protected string tokusei = "";
		}
		public class Preparation
		{
				/// <summary>
				/// DataBases/
				/// </summary>
				public static string DATABASE = "DataBases/";
				/// <summary>
				/// 861
				/// </summary>
				public static int MEMBER = 861;
				/// <summary>
				/// 405
				/// </summary>
				public static int ITEM = 405;
		}
}