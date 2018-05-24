using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VideoManager : MonoBehaviour {

	[Header("COMPONENT SETTINGS")]
	public VideoPlayer videoComponent;
	public VideoManager videoManager;

	[Header("TIME SETTINGS")]
	public Slider durationSlider;
	public Text currentTime;
	public Text durationTime;

	[Header("PLAYER")]
	public GameObject playIcon;
	public GameObject pauseIcon;
	public Animator playButtonAnimator;
	public Animator playPauseBigAnimator;

	int secondsPassed;
	int minutesPassed;
	int totalSeconds;
	int totalMinutes;

	bool isDone;

	public bool IsPlaying 
	{
		get { return videoComponent.isPlaying; }
	}

	public bool IsLooping {
		get { return videoComponent.isLooping; }
	}

	public bool IsPrepared {
		get { return videoComponent.isPrepared; }
	}

	public bool IsDone {
		get { return isDone; }
	}

	public double Time {
		get { return videoComponent.time; }
	}

	public ulong Duration {
		get { return (ulong)(videoComponent.frameCount / videoComponent.frameRate); }
	}

	public double NTime {
		get { return Time / Duration; }
	}
		
	void Start() 
	{
		if (videoComponent == IsPlaying) 
		{
			playButtonAnimator.Play("Pause");
		} 

		else
		{
			playButtonAnimator.Play("Play");
		}
	}

	void Update() 
	{
		if (videoManager.IsPrepared) 
		{
			totalMinutes = (int)videoManager.Duration / 60;
			totalSeconds = (int)videoManager.Duration - totalMinutes * 60;
			minutesPassed = (int)videoManager.Time / 60;
			secondsPassed = (int)videoManager.Time - minutesPassed * 60;

			currentTime.text = string.Format("{0:00}:{1:00}", minutesPassed, secondsPassed);
			durationTime.text = string.Format("{0:00}:{1:00}", totalMinutes, totalSeconds);
			durationSlider.value = (float)NTime;
		}
	}

	public void PlayPause() 
	{
		if (videoComponent == IsPlaying) 
		{
			videoComponent.Pause();
			playButtonAnimator.Play("Play");
			playPauseBigAnimator.Play("Pause Big");
		} 

		else if (videoComponent == IsPrepared)
		{
			videoComponent.Play();
			playButtonAnimator.Play("Pause");
			playPauseBigAnimator.Play("Play Big");
		}
	}

	public void Seek(float nTime) 
	{
		if (!videoComponent.canSetTime) return;
		if (!IsPrepared) return;
		nTime = Mathf.Clamp(nTime, 0, 1);
		videoComponent.time = nTime * Duration;
	}

	public void LoopVideo(bool toggle) 
	{
		if (!IsPrepared) 
		{
			videoComponent.isLooping = toggle;
		}
	}

	public void IncrementPlaybackSpeed() 
	{
		if (!videoComponent.canSetPlaybackSpeed) return;

		videoComponent.playbackSpeed += 1; 
		videoComponent.playbackSpeed = Mathf.Clamp(videoComponent.playbackSpeed, 0, 10);
	}

	public void DecrementPlaybackSpeed() 
	{
		if (!videoComponent.canSetPlaybackSpeed) return;

		videoComponent.playbackSpeed -= 1; 
		videoComponent.playbackSpeed = Mathf.Clamp(videoComponent.playbackSpeed, 0, 10);
	}
}
