﻿using System;

using Xamarin.Forms;
using ACE;

namespace DEV
{
	public class MenuPage : ContentPage
	{
		public ListView Menu {
			get;
			set;
		}

		public MenuPage () 
		{
			Title = ResourceLoader.LocalizeString ("string_back", "");


//			Label labHeader = new Label () {
//				Text = "Hello, Forms!",
//				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
//			};
//
//			// Assemble an array of NamedColor objects.
//			NamedColor[] namedColors = {
//				new NamedColor ("Aqua", Color.Aqua),
//				new NamedColor ("Black", Color.Black),
//				new NamedColor ("Blue", Color.Blue),
//				new NamedColor ("Fuchsia", Color.Fuchsia),
//				new NamedColor ("Gray", Color.Gray),
//				new NamedColor ("Green", Color.Green),
//				new NamedColor ("Lime", Color.Lime),
//				new NamedColor ("Maroon", Color.Maroon),
//				new NamedColor ("Navy", Color.Navy),
//				new NamedColor ("Olive", Color.Olive),
//				new NamedColor ("Purple", Color.Purple),
//				new NamedColor ("Red", Color.Red),
//				new NamedColor ("Silver", Color.Silver),
//				new NamedColor ("Teal", Color.Teal),
//				new NamedColor ("White", Color.White),
//				new NamedColor ("Yellow", Color.Yellow)
//			};
//
//			// Create ListView for the master page.
//			Menu = new ListView {
//				ItemsSource = namedColors
//			};

			// Create the master page with the ListView.
			Content = new StackLayout {
				Children = {
//					labHeader,
//					Menu
				}
			};

		}
	}
}


