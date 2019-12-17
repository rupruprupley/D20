using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace D20
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ImageView imageViewDice;

        private Random rng = new Random();

        private TextView message;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            setContentView(R.layout.activity_main);
            MediaPlayer roll = MediaPlayer.create(this, R.raw.roll);
            MediaPlayer derekawe = MediaPlayer.create(this, R.raw.derekawe);
            MediaPlayer maxiumumderek = MediaPlayer.create(this, R.raw.maximumderek);
            this.message = ((TextView)(findViewById(R.id.message)));
            this.imageViewDice = findViewById(R.id.image_view_dice);
            this.imageViewDice.setOnClickListener(new View.OnClickListener());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void rollDice()
        {
            int randomNumber = (this.rng.nextInt(20) + 1);
            switch (randomNumber)
            {
                case 1:
                    this.imageViewDice.setImageResource(R.drawable.dice1);
                    this.message.setText("Critical Miss :(");
                    break;
                case 2:
                    this.imageViewDice.setImageResource(R.drawable.dice2);
                    this.message.setText("");
                    break;
                case 3:
                    this.imageViewDice.setImageResource(R.drawable.dice3);
                    this.message.setText("");
                    break;
                case 4:
                    this.imageViewDice.setImageResource(R.drawable.dice4);
                    this.message.setText("");
                    break;
                case 5:
                    this.imageViewDice.setImageResource(R.drawable.dice5);
                    this.message.setText("");
                    break;
                case 6:
                    this.imageViewDice.setImageResource(R.drawable.dice6);
                    this.message.setText("");
                    break;
                case 7:
                    this.imageViewDice.setImageResource(R.drawable.dice7);
                    this.message.setText("");
                    break;
                case 8:
                    this.imageViewDice.setImageResource(R.drawable.dice8);
                    this.message.setText("");
                    break;
                case 9:
                    this.imageViewDice.setImageResource(R.drawable.dice9);
                    this.message.setText("");
                    break;
                case 10:
                    this.imageViewDice.setImageResource(R.drawable.dice10);
                    this.message.setText("");
                    break;
                case 11:
                    this.imageViewDice.setImageResource(R.drawable.dice11);
                    this.message.setText("");
                    break;
                case 12:
                    this.imageViewDice.setImageResource(R.drawable.dice12);
                    this.message.setText("");
                    break;
                case 13:
                    this.imageViewDice.setImageResource(R.drawable.dice13);
                    this.message.setText("");
                    break;
                case 14:
                    this.imageViewDice.setImageResource(R.drawable.dice14);
                    this.message.setText("");
                    break;
                case 15:
                    this.imageViewDice.setImageResource(R.drawable.dice15);
                    this.message.setText("");
                    break;
                case 16:
                    this.imageViewDice.setImageResource(R.drawable.dice16);
                    this.message.setText("");
                    break;
                case 17:
                    this.imageViewDice.setImageResource(R.drawable.dice17);
                    this.message.setText("");
                    break;
                case 18:
                    this.imageViewDice.setImageResource(R.drawable.dice18);
                    this.message.setText("");
                    break;
                case 19:
                    this.imageViewDice.setImageResource(R.drawable.dice19);
                    this.message.setText("");
                    break;
                case 20:
                    this.imageViewDice.setImageResource(R.drawable.dice20);
                    this.message.setText("Critical Hit!! Raaaaadddddd");
                    break;
            }
        }

    }
}