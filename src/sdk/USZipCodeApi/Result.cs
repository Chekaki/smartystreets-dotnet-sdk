﻿using System;
using System.Runtime.Serialization;

namespace SmartyStreets.USZipCodeApi
{
	[DataContract]
	public class Result
	{
		#region [ Fields ]

		[DataMember(Name = "status")]
		public string Status { get; private set; }

		[DataMember(Name = "reason")]
		public string Reason { get; private set; }

		[DataMember(Name = "input_index")]
		public int InputIndex { get; private set; }

		[DataMember(Name = "city_states")]
		public CityState[] CityStates { get; private set; }

		[DataMember(Name = "zipcodes")]
		public ZipCode[] ZipCodes { get; private set; }

		#endregion

		public bool IsValid()
		{
			return (this.Status == null && this.Reason == null);
		}

		public CityState GetCityState(int index)
		{
			return this.CityStates[index];
		}

		public ZipCode GetZipCode(int index)
		{
			return this.ZipCodes[index];
		}
	}
}
