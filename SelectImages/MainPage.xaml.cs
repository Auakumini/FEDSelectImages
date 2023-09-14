using System.Collections.ObjectModel;
using SelectImages.Models;

namespace SelectImages
{
    public partial class MainPage : ContentPage
    {

        private string _imagePath = "";
        public ObservableCollection<ImageInfo> Images { get; set; } = new();
        public MainPage()
        {
            InitializeComponent();
    }

        private async void selectImageBtn_Clicked(object sender, EventArgs e)
        {
            var image = await FilePicker.Default.PickAsync(new PickOptions
            {
                PickerTitle = "Pick Image",
                FileTypes = FilePickerFileType.Images
            });
            if (image != null)
            {
                _imagePath = image.FullPath.ToString();
                SelectedImage.Source = _imagePath;
            }
        }

        private async void addImageBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}