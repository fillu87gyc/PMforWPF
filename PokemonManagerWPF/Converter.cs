namespace Convertar
{
		using System;
		using System.Globalization;
		using System.Windows.Data;

		public class PathConverter : IValueConverter
		{
				object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
				{
						return "images/system/" + value.ToString() + ".png";
				}
				object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
				{
						return value.ToString().Replace("images/system/", "").Replace(".png", "");
				}
		}
		public class EffAndIndConverter : IValueConverter
		{
				object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
				{
						var bar = value as int[];
						return "H:" + bar[0] + "  A:" + bar[1] + "  B:" + bar[2] + "  C:" + bar[3] + "  D:" + bar[4] + "  S:" + bar[5];
				}
				object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
				{
						return new NotImplementedException();
				}
		}
}