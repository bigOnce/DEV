﻿using System;

using Xamarin.Forms;
using ACE;

namespace DEV
{
	public class RootPage : TabbedPage
	{
		public RootPage ()
		{

			Title = ResourceLoader.LocalizeString ("string_tab_video", "");

			var FirstPage = new HomePage ();
//			FirstPage.Icon = "icon.png";
			FirstPage.Title = ResourceLoader.LocalizeString ("string_tab_video", "");

			var SecondPage = new GeneralPage ();
//			SecondPage.Icon = "icon.png";
			SecondPage.Title = ResourceLoader.LocalizeString ("string_tab_livescore", "");

			Children.Add (FirstPage);
			Children.Add (SecondPage);

			APIRequestManager.TestGetJSONRequest ();

		}
	}
}


  