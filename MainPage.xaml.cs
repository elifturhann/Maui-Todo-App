﻿using LifeManagementApp.ViewModel;

namespace LifeManagementApp;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	

}

