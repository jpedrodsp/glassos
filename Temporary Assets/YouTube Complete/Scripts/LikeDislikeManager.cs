using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LikeDislikeManager : MonoBehaviour {

	[Header("OBJECTS")]
	public Text likeText;
	public Text dislikeText;
	public Slider countSlider;

	[Header("COUNTERS")]
	public int likeCount;
	public int dislikeCount;
	private int likeCountBeforeAction;
	private int dislikeCountBeforeAction;

	[Header("VARIABLES")]
	public CheckLike likedOrDisliked;

	[Header("ANIMATORS")]
	public Animator likeAnimator;
	public Animator dislikeAnimator;
	private string likeIn = "Like Fade In";
	private string likeOut = "Like Fade Out";
	private string dislikeIn = "Dislike Fade In";
	private string dislikeOut = "Dislike Fade Out";

	public enum CheckLike
	{
		NONE,
		LIKED,
		DISLIKED
	}

	void Start () 
	{
		likeCountBeforeAction = likeCount;
		dislikeCountBeforeAction = dislikeCount;

		likeText.text = likeCount.ToString ();
		dislikeText.text = dislikeCount.ToString();

		if (likeCount >= 1000) {
			likeCount = likeCount / 1000;
			likeText.text = likeCount + " K";
		}

		if (dislikeCount >= 1000) {
			dislikeCount = dislikeCount / 1000;
			dislikeText.text = dislikeCount + " K";
		}

		if (likedOrDisliked == CheckLike.LIKED) 
		{
			likeAnimator.Play (likeIn);
		}

		if (likedOrDisliked == CheckLike.DISLIKED) 
		{
			dislikeAnimator.Play (dislikeIn);
		}
	}

	public void Like ()
	{
		if (likedOrDisliked == CheckLike.LIKED) 
		{
			likeCount = likeCountBeforeAction;
			likeText.text = likeCount.ToString();
			likedOrDisliked = CheckLike.NONE;
			likeAnimator.Play (likeOut);
		} 

		else if (likedOrDisliked == CheckLike.DISLIKED)
		{
			likeCount = likeCountBeforeAction;
			likeCount += 1;
			likeText.text = likeCount.ToString();

			dislikeCount = dislikeCountBeforeAction;
			dislikeText.text = dislikeCount.ToString();

			likedOrDisliked = CheckLike.LIKED;

			likeAnimator.Play (likeIn);
			dislikeAnimator.Play (dislikeOut);
		}

		else if (likedOrDisliked == CheckLike.NONE)
		{
			likeCount = likeCountBeforeAction;
			likeCount += 1;
			likeText.text = likeCount.ToString();
			likedOrDisliked = CheckLike.LIKED;
			likeAnimator.Play (likeIn);

		}

		if (likeCount >= 1000) {
			likeCount = likeCount / 1000;
			likeText.text = likeCount + " K";
		}

		else if (likeCount <= 1000) 
		{
			likeText.text = likeCount.ToString();
		}

		if (dislikeCount >= 1000) {
			dislikeCount = dislikeCount / 1000;
			dislikeText.text = dislikeCount + " K";
		}

		else if (dislikeCount <= 1000) 
		{
			dislikeText.text = dislikeCount.ToString();
		}
	}

	public void Dislike ()
	{
		if (likedOrDisliked == CheckLike.LIKED)
		{
			likeCount = likeCountBeforeAction;
			likeText.text = likeCount.ToString();

			dislikeCount = dislikeCountBeforeAction;
			dislikeCount += 1;
			dislikeText.text = dislikeCount.ToString();

			likedOrDisliked = CheckLike.DISLIKED;

			likeAnimator.Play (likeOut);
			dislikeAnimator.Play (dislikeIn);
		} 

		else if (likedOrDisliked == CheckLike.DISLIKED)
		{
			dislikeCount = dislikeCountBeforeAction;
			dislikeText.text = dislikeCount.ToString();
			likedOrDisliked = CheckLike.NONE;
			dislikeAnimator.Play (dislikeOut);

		}

		else if (likedOrDisliked == CheckLike.NONE)
		{
			dislikeCount = dislikeCountBeforeAction;
			dislikeText.text = dislikeCount.ToString();
			dislikeCount += 1;
			likedOrDisliked = CheckLike.DISLIKED;
			dislikeAnimator.Play (dislikeIn);
		}

		if (dislikeCount >= 1000) {
			dislikeCount = dislikeCount / 1000;
			dislikeText.text = dislikeCount + " K";
		}

		else if (dislikeCount <= 1000) 
		{
			dislikeText.text = dislikeCount.ToString();
		}

		if (likeCount >= 1000) {
			likeCount = likeCount / 1000;
			likeText.text = likeCount + " K";
		}

		else if (likeCount <= 1000) 
		{
			likeText.text = likeCount.ToString();
		}
	}
}