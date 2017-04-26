using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace PokemonManagerWPF
{
		using Base;
		/// <summary>
		/// MainWindow.xaml の相互作用ロジック
		/// </summary>
		public partial class MainWindow : Window
		{
				public MainWindow()
				{
						InitializeComponent();
						this.DataContext = new NoData();
				}
				public class NoData : Base.Property
				{
						public NoData()
						{
								ImgSource ="images/system/noimage.png";
								Name = "NoName";
								ImgType1 = "fire";
								ImgType2 = "ice";
								Tokusei = "まじめ";
								Ability = "ほげ";
								StatusMgr = new StatusManager.Status();
						}

				}

				private void CheckBox_Click(object sender, RoutedEventArgs e)
				{
						Image_Icon.Width++;
				}
		}

}
