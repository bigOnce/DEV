using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using Xamarin.Forms;

namespace DEV
{
	public class APIRequest
	{

		public static String Get (String url) {
			return (GetAsync (url)).Result;
		}

		public static Task<String> GetAsync (String url) {
			return (new HttpClient ()).GetStringAsync (url);
		}
			
	}
}

