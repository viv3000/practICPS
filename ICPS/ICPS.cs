using System.Windows.Forms;

using ICPS.Forms;

namespace ICPS
{
	static class ICPS // class initializator
	{
		private static bool _isLogin = false;

		public static void Run()
		{
			OpenMainMenu();
		}

		private static void OpenMainMenu()
		{
			Application.Run(FormFactory.CreateCRUD());
			/*
			if (_isLogin) Application.Run(this.Login());
			else Application.Run(this.Login());
			*/
		}

		/*
		private static MenuForm Login()
		{
			
			LoginForm loginForm = new LoginForm();
			ExceptionHandler.Handle(loginForm.LoginException);
			return loginForm.MenuForm();
			
		}
		*/
	}
}
