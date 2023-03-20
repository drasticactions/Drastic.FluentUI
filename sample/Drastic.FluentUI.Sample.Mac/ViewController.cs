using FluentUI.MacOS;
using Masonry;
using ObjCRuntime;

namespace Drastic.FluentUI.Sample.Mac;

public partial class ViewController : NSViewController {

    private MSFButton button;

    protected ViewController (NativeHandle handle) : base (handle)
	{
		// This constructor is required if the view controller is loaded from a xib or a storyboard.
		// Do not put any initialization here, use ViewDidLoad instead.
	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

        this.button = new MSFButton() { Title = "Test Button" };

        this.View!.AddSubview(this.button);
        this.button.MakeConstraints((make) => {
            make.Center.EqualTo(this.View!);
        });
    }

	public override NSObject RepresentedObject {
		get => base.RepresentedObject;
		set {
			base.RepresentedObject = value;

			// Update the view, if already loaded.
		}
	}
}
