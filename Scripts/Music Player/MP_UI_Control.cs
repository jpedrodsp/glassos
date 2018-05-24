using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP_UI_Control : MonoBehaviour {

	[Header("ANIMATORS")]
	public Animator controlsAnimator;
	public Animator homeAnimator;
	public Animator playingAnimator;
	public Animator songsAnimator;
	public Animator artistAnimator;
	public Animator playlistAnimator;

	[Header("OBJECT")]
	public GameObject homeUnderline;
	public GameObject playingUnderline;
	public GameObject songsUnderline;
	public GameObject artistUnderline;
	public GameObject playlistUnderline;

	[Header("SETTINGS")]
	public CurrentPanel currentPanel;
	private bool isControlsMinimized = false;

	public enum CurrentPanel
	{
		HOME,
		PLAYING,
		SONGS,
		ARTIST,
		PLAYLIST
	}

	void Start ()
	{
		currentPanel = CurrentPanel.HOME;
		homeUnderline.SetActive (true);
		playingUnderline.SetActive (false);
		songsUnderline.SetActive (false);
		artistUnderline.SetActive (false);
		playlistUnderline.SetActive (false);
	}

	public void HomeButton () 
	{
		if (currentPanel == CurrentPanel.PLAYING) 
		{
			playingAnimator.Play ("MP Panel Fade-out");
			homeAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.SONGS) 
		{
			songsAnimator.Play ("MP Panel Fade-out");
			homeAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.ARTIST) 
		{
			artistAnimator.Play ("MP Panel Fade-out");
			homeAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.PLAYLIST) 
		{
			playlistAnimator.Play ("MP Panel Fade-out");
			homeAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}
		currentPanel = CurrentPanel.HOME;
		homeUnderline.SetActive (true);
		playingUnderline.SetActive (false);
		songsUnderline.SetActive (false);
		artistUnderline.SetActive (false);
		playlistUnderline.SetActive (false);
	}

	public void PlayingButton () 
	{
		if (currentPanel == CurrentPanel.HOME) 
		{
			homeAnimator.Play ("MP Panel Fade-out");
			playingAnimator.Play ("MP Panel Fade-in");
			controlsAnimator.Play ("Music Controls Normalize");
			isControlsMinimized = false;
		}

		else if (currentPanel == CurrentPanel.SONGS) 
		{
			songsAnimator.Play ("MP Panel Fade-out");
			playingAnimator.Play ("MP Panel Fade-in");
			controlsAnimator.Play ("Music Controls Normalize");
			isControlsMinimized = false;
		}

		else if (currentPanel == CurrentPanel.ARTIST) 
		{
			artistAnimator.Play ("MP Panel Fade-out");
			playingAnimator.Play ("MP Panel Fade-in");
			controlsAnimator.Play ("Music Controls Normalize");
			isControlsMinimized = false;
		}

		else if (currentPanel == CurrentPanel.PLAYLIST) 
		{
			playlistAnimator.Play ("MP Panel Fade-out");
			playingAnimator.Play ("MP Panel Fade-in");
			controlsAnimator.Play ("Music Controls Normalize");
			isControlsMinimized = false;
		}
		currentPanel = CurrentPanel.PLAYING;
		homeUnderline.SetActive (false);
		playingUnderline.SetActive (true);
		songsUnderline.SetActive (false);
		artistUnderline.SetActive (false);
		playlistUnderline.SetActive (false);
	}

	public void SongsButton () 
	{
		if (currentPanel == CurrentPanel.PLAYING) 
		{
			playingAnimator.Play ("MP Panel Fade-out");
			songsAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.HOME) 
		{
			homeAnimator.Play ("MP Panel Fade-out");
			songsAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.ARTIST) 
		{
			artistAnimator.Play ("MP Panel Fade-out");
			songsAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.PLAYLIST) 
		{
			playlistAnimator.Play ("MP Panel Fade-out");
			songsAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}
		currentPanel = CurrentPanel.SONGS;
		homeUnderline.SetActive (false);
		playingUnderline.SetActive (false);
		songsUnderline.SetActive (true);
		artistUnderline.SetActive (false);
		playlistUnderline.SetActive (false);
	}

	public void ArtistButton () 
	{
		if (currentPanel == CurrentPanel.PLAYING) 
		{
			playingAnimator.Play ("MP Panel Fade-out");
			artistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.SONGS) 
		{
			songsAnimator.Play ("MP Panel Fade-out");
			artistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.HOME) 
		{
			homeAnimator.Play ("MP Panel Fade-out");
			artistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.PLAYLIST) 
		{
			playlistAnimator.Play ("MP Panel Fade-out");
			artistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}
		currentPanel = CurrentPanel.ARTIST;
		homeUnderline.SetActive (false);
		playingUnderline.SetActive (false);
		songsUnderline.SetActive (false);
		artistUnderline.SetActive (true);
		playlistUnderline.SetActive (false);
	}

	public void PlaylistButton () 
	{
		if (currentPanel == CurrentPanel.PLAYING) 
		{
			playingAnimator.Play ("MP Panel Fade-out");
			playlistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.SONGS) 
		{
			songsAnimator.Play ("MP Panel Fade-out");
			playlistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.ARTIST) 
		{
			artistAnimator.Play ("MP Panel Fade-out");
			playlistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}

		else if (currentPanel == CurrentPanel.HOME) 
		{
			homeAnimator.Play ("MP Panel Fade-out");
			playlistAnimator.Play ("MP Panel Fade-in");

			if (isControlsMinimized == false)
			{
				controlsAnimator.Play ("Music Controls Minimize");
				isControlsMinimized = true;
			}
		}
		currentPanel = CurrentPanel.PLAYLIST;
		homeUnderline.SetActive (false);
		playingUnderline.SetActive (false);
		songsUnderline.SetActive (false);
		artistUnderline.SetActive (false);
		playlistUnderline.SetActive (true);
	}
}