using Android.App;
using Android.Gms.Maps;
using Android.OS;
using Android.Support.V7.App;

namespace androidTest
{
    [Activity(Label = "Map")]
    public class MapActivity : AppCompatActivity, IOnMapReadyCallback
    {
        private GoogleMap _map;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.activity_map);
            
            var mapFragment = (MapFragment) FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }
        
        public void OnMapReady(GoogleMap map)
        {
            // Do something with the map, i.e. add markers, move to a specific location, etc.
            _map = map;
        }
    }
}