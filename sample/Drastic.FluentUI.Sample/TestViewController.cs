using System;
using Masonry;

namespace Drastic.FluentUI.Sample
{
	public class TestViewController : UIViewController
	{
		private MSFButton button;
		private MSFCardView cardView;

        public TestViewController()
		{
			this.cardView = new MSFCardView(MSFCardSize.Small,
				"Test!",
				"Fun Fun!",
				UIImage.GetSystemImage("circle")!,
				MSFCardColorStyle.Neutral);
			this.button = new MSFButton();
			this.button.SetTitle("Test Button", UIControlState.Normal);

			// this.View!.AddSubview(this.button);
			this.View!.AddSubview(this.cardView);
			this.cardView.MakeConstraints((make) => {
				make.Center.EqualTo(this.View!);
			});
        }
	}
}

