using CollectionViewBounceSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CollectionView), typeof(NoBounceRenderer))]
namespace CollectionViewBounceSample.iOS
{
    public class NoBounceRenderer : CollectionViewRenderer
    {
        public NoBounceRenderer()
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<GroupableItemsView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
                Controller.CollectionView.Bounces = false;
        }
    }
}
