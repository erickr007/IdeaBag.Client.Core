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


		#region View Builder Methods

		private void BuildLayout(){
			this.View.BackgroundColor = UIColor.Red;

			//- Add Logo
			UIImage ideabagLogo = UIImage.FromBundle("Login-Logo").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
			UIImageView ideabagLogView = new UIImageView (ideabagLogo);
			ideabagLogView.Frame =  new CoreGraphics.CGRect (97, 31, 184, 294);

			this.View.Add (ideabagLogView);

			//- Signup Image
			UIButton btnSignupImage = new UIButton();
			btnSignupImage.Frame = new CoreGraphics.CGRect (194, 313, 150, 50);

			UIImage signupImage = UIImage.FromBundle ("btnSignup-unselected").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal);
			UIImageView signupImageView = new UIImageView (signupImage);
			btnSignupImage.Add (signupImageView);

			this.View.Add (btnSignupImage);

			//- Username text box and background
			UIImageView usernameBackgroundView = new UIImageView(new UIImage (
				new CoreImage.CIImage (UIImage.FromBundle ("login-form-background").ImageWithRenderingMode (UIImageRenderingMode.AlwaysOriginal))
			));
			usernameBackgroundView.Frame = new CoreGraphics.CGRect (0, 366, 380, 50);


			UITextField tfUsername = new UITextField (new CoreGraphics.CGRect (16, 376, 343, 30));
			tfUsername.Font = UIFont.FromName ("Avenir Book", 17);
			tfUsername.Alpha = 1;
			tfUsername.BackgroundColor = UIColor.Clear;
			tfUsername.TextColor = UIColor.White;
			tfUsername.Placeholder = "Email or Username";

			this.View.Add (usernameBackgroundView);
			this.View.Add (tfUsername);

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


			//- Forgot password
			UIButton btnForgotPassword = new UIButton(new CoreGraphics.CGRect(94,556, 187, 30));
			btnForgotPassword.Font = UIFont.FromName ("Avenir Book", 19);
			btnForgotPassword.SetTitleColor (UIColor.White, UIControlState.Normal);
			btnForgotPassword.SetTitleShadowColor (UIColor.DarkTextColor, UIControlState.Normal);
			btnForgotPassword.SetTitle ("Forgot Password?", UIControlState.Normal);

			this.View.Add (btnForgotPassword);

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

