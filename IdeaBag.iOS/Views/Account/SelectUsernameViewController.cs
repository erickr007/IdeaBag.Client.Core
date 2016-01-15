using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IdeaBag.Client.iOS.Views
{
	public class SelectUsernameViewController : UIViewController
	{
		#region Private Properties



		#endregion


		#region Constructor
		
		public SelectUsernameViewController ()
		{
			BuildLayout ();
		}

		#endregion


		#region View Builder Methods

		private void BuildLayout(){
			this.View.BackgroundColor = UIColor.Red;

			//- Pick Username Label
			UILabel lblPickUsername = new UILabel (new CoreGraphics.CGRect (103, 311, 175, 26));
			lblPickUsername.Font = UIFont.FromName ("Avenir Medium", 23);
			lblPickUsername.BackgroundColor = UIColor.White;
			lblPickUsername.Text = "Pick a Username";

			this.View.Add (lblPickUsername);

			//- Username Input
			UIImageView usernameBackgroundView = new UIImageView(new UIImage (
				new CoreImage.CIImage (UIImage.FromBundle ("login-form-background").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal))
			));
			usernameBackgroundView.Frame = new CoreGraphics.CGRect (0, 366, 380, 50);
			this.View.Add (usernameBackgroundView);

			UITextField usernameText = new UITextField (new CoreGraphics.CGRect (16, 376, 343, 30));
			this.View.Add (usernameText);

			//- Done Button
			UIButton btnDone = new UIButton(new CoreGraphics.CGRect(62, 449,256,45));
			btnDone.BackgroundColor = new UIColor (255, 255, 255, 0.85f);
			btnDone.Font = UIFont.FromName ("Avenir Book", 22);
			btnDone.SetTitleShadowColor (UIColor.DarkGray, UIControlState.Normal);
			btnDone.SetTitleColor (UIColor.Red, UIControlState.Normal);
			btnDone.SetTitle ("Done", UIControlState.Normal);
			btnDone.Layer.CornerRadius = 5;
			btnDone.ClipsToBounds = true;

			this.View.Add (btnDone);


		}

		#endregion


	}
}
