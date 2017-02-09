using Android.App;
using Android.Widget;
using Android.OS;

namespace CoinConverterAndroid
{
    [Activity(Label = "CoinConverterAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView (Resource.Layout.Main);

            Button btnConvert = FindViewById<Button>(Resource.Id.btnconvert);
            EditText txtDolars = FindViewById<EditText>(Resource.Id.txtdolars);
            EditText txtPesos = FindViewById<EditText>(Resource.Id.txtpesos);
            EditText txtReais = FindViewById<EditText>(Resource.Id.txtreais);

            double pesos, reais, dolars;

            btnConvert.Click += delegate
            {
                try
                {
                    dolars = double.Parse(txtDolars.Text);
                    pesos = dolars * 19.5;
                    txtPesos.Text = pesos.ToString();
                    reais = dolars * 3.5;
                    txtReais.Text = reais.ToString();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                    throw;
                }
            };
        }
    }
}

