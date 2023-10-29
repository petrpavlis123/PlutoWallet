﻿using System;
using CommunityToolkit.Mvvm.ComponentModel;
using PlutoWallet.Model.AzeroId;
using PlutoWallet.Model;
using PlutoWallet.Model.AjunaExt;
using AzeroIdResolver;

namespace PlutoWallet.Components.AzeroId
{
	public partial class AzeroPrimaryNameViewModel : ObservableObject
	{
		[ObservableProperty]
		private string primaryName;

		[ObservableProperty]
		private string tld;

		[ObservableProperty]
		private string reservedUntil;

		[ObservableProperty]
		private bool reservedUntilIsVisible;

		public AzeroPrimaryNameViewModel()
		{
			primaryName = "Loading";
			reservedUntilIsVisible = false;
		}

		public async Task GetPrimaryName(SubstrateClientExt client)
		{
			var temp = await TzeroId.GetPrimaryNameForAddress(client, KeysModel.GetSubstrateKey());

			if (temp == null) {

				PrimaryName = "None";
                ReservedUntilIsVisible = false;
            }
			else
			{
				PrimaryName = temp.ToUpper();
				Tld = ("." + await TzeroId.GetTld(client)).ToUpper();

				var period = await TzeroId.GetRegistrationPeriodForName(temp);

				if (period != null)
				{
                    ReservedUntil = period.Value.Item2.Day + "." + period.Value.Item2.Month + "." + period.Value.Item2.Year;
					ReservedUntilIsVisible = true;
                }
            }
		}
	}
}

