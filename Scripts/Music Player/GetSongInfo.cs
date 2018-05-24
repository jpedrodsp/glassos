using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetSongInfo : MonoBehaviour {

	[Header("OBJECTS")]
	public Text songTitleObj;
	public Text artistTitleObj;
	public Text songTitleMini;
	public Image coverImageObj;
	public Image coverImageBGObj;
	public Image coverAnimHelper;
	public Image coverBGAnimHelper;

	[Header("VARIABLES")]
	public Sprite coverImage;
	public Sprite coverBGImage;

	[Header("SONG INFO")]
	public Animator coverAnimator;
	public Animator coverBGAnimator;
	public string coverAnimNext;
	public string coverBGAnimNext;
	private bool isStopped = true;

	public void CoverAnimNext () 
	{
		coverAnimHelper.sprite = coverImageObj.sprite;
		coverAnimator.Play ("Empty");
		coverAnimator.Play (coverAnimNext);

		coverBGAnimHelper.sprite = coverImageObj.sprite;
		coverBGAnimator.Play ("Empty");
		coverBGAnimator.Play (coverBGAnimNext);
	}
		
	public void CoverAnimPlay () 
	{
		if (isStopped == true)
		{
			coverAnimHelper.sprite = coverImageObj.sprite;
			coverAnimator.Play ("Empty");
			coverAnimator.Play (coverAnimNext);

			coverBGAnimHelper.sprite = coverImageObj.sprite;
			coverBGAnimator.Play ("Empty");
			coverBGAnimator.Play (coverBGAnimNext);
			isStopped = false;
		}
	}

	void Update () 
	{
		if (songTitleObj.text == "Stressed Out (Tomsize Remix)")
		{
			artistTitleObj.text = "Twenty One Pilots";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Stressed Out");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Stressed Out");
		}

		else if (songTitleObj.text == "Paper Love")
		{
			artistTitleObj.text = "Allie X";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Paper Love");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Paper Love");
		}

		else if (songTitleObj.text == "Downtown")
		{
			artistTitleObj.text = "Allie X";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Paper Love");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Paper Love");
		}

		else if (songTitleObj.text == "On That Day")
		{
			artistTitleObj.text = "Desmeon";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/On That Day");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/On That Day");
		}

		else if (songTitleObj.text == "Undone")
		{
			artistTitleObj.text = "Desmeon feat. Steklo";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Undone");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Undone");
		}

		else if (songTitleObj.text == "Energy")
		{
			artistTitleObj.text = "Elektronomia";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Energy");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Energy");
		}

		else if (songTitleObj.text == "Everlasting")
		{
			artistTitleObj.text = "Ephixa & Jim Yosef";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Everlasting");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Everlasting");
		}

		else if (songTitleObj.text == "In These Shadows")
		{
			artistTitleObj.text = "Fytch feat. Carmen Forbes";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/In These Shadows");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/In These Shadows");
		}

		else if (songTitleObj.text == "Lonely Road")
		{
			artistTitleObj.text = "Hendersin";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Lonely Road");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Album Covers/Lonely Road");
		}

		else
		{
			songTitleObj.text = "Not playing";
			artistTitleObj.text = "Not playing";
			coverImageObj.sprite = Resources.Load<Sprite>("Album Covers/Default Cover");
			coverImageBGObj.sprite = Resources.Load<Sprite>("Music Player BG/Default BG");
		}
		songTitleMini.text = songTitleObj.text;
	}
}
