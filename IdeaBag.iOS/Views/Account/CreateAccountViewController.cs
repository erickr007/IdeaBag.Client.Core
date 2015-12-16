using System;
using UIKit;

namespace IdeaBag.Client.iOS.Views
{
	public class CreateAccountViewController : UIViewController
	{
		#region Constructor

		public CreateAccountViewController ()
		{
			BuildLayout ();
		}

		#endregion


		#region View Builder Methods

		private void BuildLayout(){
			this.View.BackgroundColor = UIColor.Red;
			
			//- Logo
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


			UITextField tfEmail = new UITextField (new CoreGraphics.CGRect (16, 376, 343, 30));
			tfEmail.Font = UIFont.FromName ("Avenir Book", 17);
			tfEmail.Alpha = 1;
			tfEmail.BackgroundColor = UIColor.Clear;
			tfEmail.TextColor = UIColor.White;
			tfEmail.Placeholder = "Email";

			this.View.Add (usernameBackgroundView);
			this.View.Add (tfEmail);

			//- Password text box and background
			UIImageView passwordBackgroundView = new UIImageView(new UIImage (
				new CoreImage.CIImage (UIImage.FromBundle ("login-form-background").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal))
			));
			passwordBackgroundView.Frame = new CoreGraphics.CGRect (0, 418, 380, 50);

			UITextField tfPassword = new UITextField (
				new CoreGraphics.CGRect (16, 428, 343, 30));
			tfPassword.Font = UIFont.FromName ("Avenir Book", 17);
			tfPassword.Alpha = 1;
			tfPassword.BackgroundColor = UIColor.Clear;
			tfPassword.TextColor = UIColor.White;
			tfPassword.Placeholder = "Password";

			this.View.Add (passwordBackgroundView);
			this.View.Add (tfPassword);

			//- Create Account Button
			UIButton btnLogin = new UIButton(new CoreGraphics.CGRect(59, 479, 256, 49));
			btnLogin.Font = UIFont.FromName ("Avenir Book", 22);
			btnLogin.BackgroundColor = new UIColor (new CoreGraphics.CGColor (255, 255, 255, 0.85f));
			btnLogin.SetTitleShadowColor (UIColor.DarkGray, UIControlState.Normal);
			btnLogin.SetTitleColor (UIColor.Red, UIControlState.Normal);
			btnLogin.SetTitle ("Create Account", UIControlState.Normal);
			btnLogin.Layer.CornerRadius = 5;
			btnLogin.ClipsToBounds = true;

			this.View.Add (btnLogin);

			//- Facebook login
			UIButton btnFacebookLogin = new UIButton(new CoreGraphics.CGRect(73, 623, 228, 32));
			btnFacebookLogin.Font = UIFont.FromName ("Avenir Book", 18);
			btnFacebookLogin.SetTitle ("Login with Facebook", UIControlState.Normal);
			btnFacebookLogin.SetTitleColor (UIColor.White, UIControlState.Normal);
			btnFacebookLogin.SetImage (
				UIImage.FromBundle ("Facebook-login").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal),
				UIControlState.Normal);
			this.View.Add (btnFacebookLogin);
		}

		#endregion
	}
}

