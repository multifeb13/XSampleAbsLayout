using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XSampleAbsLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent( );

            Image_user.Source = ImageSource.FromResource( "XSampleAbsLayout.Resources.Images.image_user.png" );
            Image_frame.Source = ImageSource.FromResource( "XSampleAbsLayout.Resources.Images.image_frame.png" );

            var tgr_user = new TapGestureRecognizer( );
            tgr_user.Tapped += ( s, e ) =>
            {
                DisplayAlertDialog( );
            };
            Image_user.GestureRecognizers.Add( tgr_user );
            
        }

        private void DisplayAlertDialog( )
        {
            DisplayAlert( "", "Tap", "OK" );
        }
    }

}
