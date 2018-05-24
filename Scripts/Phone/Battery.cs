using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour {

	public int batteryLife;
	public Text batteryText;

	public static float GetBatteryLevel()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			try
			{
				using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
				{
					if (null != unityPlayer)
					{
						using (AndroidJavaObject currActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
						{
							if (null != currActivity)
							{
								using (AndroidJavaObject intentFilter = new AndroidJavaObject("android.content.IntentFilter", new object[]{ "android.intent.action.BATTERY_CHANGED" }))
								{
									using (AndroidJavaObject batteryIntent = currActivity.Call<AndroidJavaObject>("registerReceiver", new object[]{null,intentFilter}))
									{
										int level = batteryIntent.Call<int>("getIntExtra", new object[]{"level",-1});
										int scale = batteryIntent.Call<int>("getIntExtra", new object[]{"scale",-1});

										// Error checking that probably isn't needed but I added just in case.
										if (level == -1 || scale == -1)
										{
											return 50f;
										}
										return ((float)level / (float)scale) * 100.0f;
									}

								}
							}
						}
					}
				}
			} catch (System.Exception ex)
			{
				
			}
		}
		return 100;
	}
}