using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class MusicTagDisplay : MonoBehaviour {

    [Header("CORE SCRIPTS")]
    public MusicPlayerCore corePlayer;
    public List <MusicTag> tags;
    public MusicTag currentTag;

    [Header("OBJECTS")]
    private string songTitleText;
    public Text songTitle;
	public Text artistTitle;
	public Image coverImage;
	public Image coverImageBG;
	public Image coverAnimHelper;
	public Image coverBGAnimHelper;

    [Header("MINI OBJECTS")]
    public Text songTitleMini;
    public Text artistTitleMini;
    public Image coverImageMini;
    public Image coverAnimHelperMini;

    [Header("SONG INFO")]
	public Animator coverAnimator;
    public Animator coverAnimatorMini;
    public Animator coverBGAnimator;

    bool isPlayed = false;

	public void ChangeState() 
	{
        coverAnimHelper.sprite = currentTag.artwork;
        coverAnimHelperMini.sprite = currentTag.artwork;
        coverBGAnimHelper.sprite = currentTag.artwork;

        songTitleText = corePlayer.source.clip.name;
        currentTag = tags.Where(obj => obj.name == songTitleText).SingleOrDefault();

        songTitle.text = currentTag.songName;
        songTitleMini.text = currentTag.songName;
        artistTitle.text = currentTag.artistName;
        artistTitleMini.text = currentTag.artistName;

        coverImage.sprite = currentTag.artwork;
        coverImageMini.sprite = currentTag.artwork;
        coverImageBG.sprite = currentTag.artwork;

		coverAnimator.Play ("Empty");
		coverAnimator.Play ("Cover Change");

		coverBGAnimator.Play ("Empty");
		coverBGAnimator.Play ("Cover BG Change");
    }

    public void PlayState()
    {
        coverAnimHelper.sprite = currentTag.artwork;
        coverAnimHelperMini.sprite = currentTag.artwork;
        coverBGAnimHelper.sprite = currentTag.artwork;

        songTitleText = corePlayer.source.clip.name;
        currentTag = tags.Where(obj => obj.name == songTitleText).SingleOrDefault();

        songTitle.text = currentTag.songName;
        songTitleMini.text = currentTag.songName;
        artistTitle.text = currentTag.artistName;
        artistTitleMini.text = currentTag.artistName;

        if (isPlayed == false)
        {
            coverImage.sprite = currentTag.artwork;
            coverImageMini.sprite = currentTag.artwork;
            coverImageBG.sprite = currentTag.artwork;

            coverAnimator.Play("Empty");
            coverAnimator.Play("Cover Change");
            coverAnimatorMini.Play("Empty");
            coverAnimatorMini.Play("Cover Change");

            coverBGAnimator.Play("Empty");
            coverBGAnimator.Play("Cover BG Change");

            isPlayed = true;
        }
    }
}
