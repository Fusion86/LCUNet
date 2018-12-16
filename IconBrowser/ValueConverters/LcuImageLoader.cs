using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace IconBrowser.ValueConverters
{
    /// <summary>
    /// Load image from SSL server with unaccepted certificate (e.g self-signed)
    /// </summary>
    public class LcuImageLoader : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                try
                {
                    // Yes, Task.Run is required, why? idk
                    var x = Task.Run(async () => await AppState.LeagueClientApi.HttpClient.GetAsync((string)value));
                    var resp = x.Result;

                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.StreamSource = resp.Content.ReadAsStreamAsync().Result;
                    image.EndInit();
                    return image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
