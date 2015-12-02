using System;
using UIKit;

namespace IdeaBag.Client.iOS.Views
{
	public class LoginViewController : UIViewController
	{
		public LoginViewController ()
		{
			BuildLayout ();
		}


		#region Design Methods

		private void BuildLayout(){
			this.View.BackgroundColor = UIColor.Red;

			//- Add Logo
			UIImage ideabagLogo = UIImage.FromBundle("Login-Logo").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
			UIImageView ideabagLogView = new UIImageView (ideabagLogo);
			ideabagLogView.Frame =  new CoreGraphics.CGRect (97, 31, 184, 294);

			this.View.Add (ideabagLogView);

			//- Login Image
			UIButton btnLoginImage = new UIButton();
			btnLoginImage.Frame = new CoreGraphics.CGRect (16, 313, 150, 50);

			UIImage loginImage = UIImage.FromBundle ("btnLogin-unselected").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal);
			UIImageView loginImageView = new UIImageView (loginImage);
			btnLoginImage.Add (loginImageView);

			this.View.Add (btnLoginImage);

			//- Username text box and background
			UIImageView usernameBackgroundView = new UIImageView(new UIImage (
				new CoreImage.CIImage (UIImage.FromBundle ("login-form-background").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal))
			));
			usernameBackgroundView.Frame = new CoreGraphics.CGRect (0, 366, 380, 50);

			UITextView tbUsername = new UITextView (
				new CoreGraphics.CGRect (16, 376, 343, 30));
			tbUsername.Font = UIFont.FromName ("Avenir Book", 17);

			this.View.Add (usernameBackgroundView);
			this.View.Add (tbUsername);

			//- Password text box and background
			UIImageView passwordBackgroundView = new UIImageView(new UIImage (
				new CoreImage.CIImage (UIImage.FromBundle ("login-form-background").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal))
			));
			passwordBackgroundView.Frame = new CoreGraphics.CGRect (0, 418, 380, 50);

			UITextView tbPassword = new UITextView (
				new CoreGraphics.CGRect (16, 428, 343, 30));
			tbPassword.Font = UIFont.FromName ("Avenir Book", 17);

			this.View.Add (passwordBackgroundView);
			this.View.Add (tbPassword);

			//- Login Button
			UIButton btnLogin = new UIButton(new CoreGraphics.CGRect(59, 479, 256, 49));
			btnLogin.Font = UIFont.FromName ("Avenir Book", 22);
			btnLogin.BackgroundColor = new UIColor (new CoreGraphics.CGColor (255, 255, 255, 0.85f));
			btnLogin.SetTitleShadowColor (UIColor.DarkGray, UIControlState.Normal);
			btnLogin.SetTitleColor (UIColor.Red, UIControlState.Normal);
			btnLogin.SetTitle ("Login", UIControlState.Normal);
			btnLogin.Layer.CornerRadius = 5;
			btnLogin.ClipsToBounds = true;

			this.View.Add (btnLogin);
		}

		#endregion
	}
}

