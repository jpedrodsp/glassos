using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class Weather : MonoBehaviour {

	[Header("OBJECTS")]
	// public Text myWeatherLabel;
	public Text cityText;
	public Text statusText;
	public Text degreeText;
	public Text descriptionText;
	public Image currentWeatherImage;

	[Header("STATUS TEXTS")]
	public string rainyText;
	public string sunnyText;
	public string snowyText;
	public string cloudyText;
	public string thunderText;

	[Header("WEATHER ICONS")]
	public Sprite rainyIcon;
	public Sprite sunnyIcon;
	public Sprite snowyIcon;
	public Sprite cloudyIcon;
	public Sprite thunderIcon;

	private string currentIP;
	private string currentCountry;
	private string currentCity;

	private string retrievedCountry;
	private string retrievedCity;
	private int conditionID;
	public string conditionName;
	private string conditionImage;

	void Start()
	{
		StartCoroutine(SendRequest());
	}

	public IEnumerator SendRequest()
	{
		//get the players IP, City, Country
		Network.Connect("http://www.google.com");
		currentIP = Network.player.externalIP;
		Network.Disconnect();

		WWW cityRequest = new WWW("http://www.geoplugin.net/json.gp?ip=" + currentIP); //get our location info
		yield return cityRequest;

		if (cityRequest.error == null || cityRequest.error == "")
		{
			var N = JSON.Parse(cityRequest.text);
			currentCity = N["geoplugin_city"].Value;
			currentCountry = N["geoplugin_countryName"].Value;
		}

		else 
		{
			Debug.Log("WWW error: " + cityRequest.error);
		}

		//get the current weather
		WWW request = new WWW("http://api.openweathermap.org/data/2.5/weather?q=" + currentCity + "&appid=bbf3c99400e129ace6868f63e9d69cbc"); //get our weather
		yield return request;

		if (request.error == null || request.error == "")
		{
			var N = JSON.Parse(request.text);

			retrievedCountry = N["sys"]["country"].Value; //get the country
			retrievedCity = N["name"].Value; //get the city

			string temp = N["main"]["temp"].Value; //get the temperature
			float tempTemp; //variable to hold the parsed temperature
			float.TryParse(temp, out tempTemp); //parse the temperature
			float finalTemp = Mathf.Round((tempTemp - 273.0f)*10)/10; //holds the actual converted temperature

			int.TryParse(N["weather"][0]["id"].Value, out conditionID); //get the current condition ID
			//conditionName = N["weather"][0]["main"].Value; //get the current condition Name
			conditionName = N["weather"][0]["description"].Value; //get the current condition Description

			//	"Country: " + retrievedCountry
			//	+ "\nCity: " + retrievedCity
			//	+ "\nTemperature: " + finalTemp + " C"
			//	+ "\nCurrent Condition: " + conditionName
			//	+ "\nCondition Code: " + conditionID;

			statusText.text = conditionName;
			cityText.text = retrievedCity + ", " + retrievedCountry;
			degreeText.text = finalTemp + "°C";

			cityText.text = cityText.text.ToUpper();

			rainyText = rainyText.Replace("\\n", "\n");
			sunnyText = sunnyText.Replace("\\n", "\n");
			snowyText = snowyText.Replace("\\n", "\n");
			cloudyText = cloudyText.Replace("\\n", "\n");
			thunderText = thunderText.Replace("\\n", "\n");


			if (conditionName == "scattered clouds" || conditionName == "few clouds" || conditionName == "broken clouds") 
			{
				descriptionText.text = cloudyText;
				currentWeatherImage.sprite = cloudyIcon;
			} 

			else if (conditionName == "rain" || conditionName == "shower rain" || conditionName == "light rain" || conditionName == "light intensity shower rain") 
			{
				descriptionText.text = rainyText;
				currentWeatherImage.sprite = rainyIcon;
			}

			else if (conditionName == "clear sky") 
			{
				descriptionText.text = sunnyText;
				currentWeatherImage.sprite = sunnyIcon;
			}

			else if (conditionName == "thunderstorm") 
			{
				descriptionText.text = thunderText;
				currentWeatherImage.sprite = thunderIcon;
			}

			else if (conditionName == "snow") 
			{
				descriptionText.text = snowyText;
				currentWeatherImage.sprite = snowyIcon;
			}
			descriptionText.text = descriptionText.text.ToUpper();
		}
		else
		{
			Debug.Log("WWW error: " + request.error);
		}
	}
}
