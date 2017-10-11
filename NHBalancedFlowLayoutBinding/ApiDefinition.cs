using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace NHBalancedFlowLayoutBinding
{
    [BaseType(typeof(UICollectionViewDelegateFlowLayout))]
    [Model]
    [Protocol]
    interface NHBalancedFlowLayoutDelegate
    {
        [Export("collectionView:layout:preferredSizeForItemAtIndexPath:")]
        [Abstract]
        CGSize PreferredSizeForItemAtIndexPath(UICollectionView cv, NHBalancedFlowLayout layout, NSIndexPath indexPath);
    }

    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface NHBalancedFlowLayout
    {
    }
}
