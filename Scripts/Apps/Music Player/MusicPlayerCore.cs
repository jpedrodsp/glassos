using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayerCore : MonoBehaviour
{
    [Header("LIST")]
    public AudioClip[] musicList;
    private AudioClip tempClip;

    [Header("RESOURCES")]
    public Text clipTimeText;
    public Text clipDurationText;
    public Slider audioSlider;
    public Animator playPauseAnimator;
    public Animator nextAnimator;
    public Animator prevAnimator;
    public Animator shuffleAnimator;
    public Animator repeatAnimator;
    public MusicTagDisplay tagDisplay;

    [Header("MINI RESOURCES")]
    public Text clipTimeTextMini;
    public Text clipDurationTextMini;
    public Slider audioSliderMini;
    public Animator playPauseAnimatorMini;
    public Animator nextAnimatorMini;
    public Animator prevAnimatorMini;
    public Animator shuffleAnimatorMini;
    public Animator repeatAnimatorMini;

    [Header("SETTINGS")]
    public bool repeat;
    public bool shuffle;

    private int currentTrack;
    private int fullLength;
    private int playTime;
    private int seconds;
    private int minutes;
    [HideInInspector] public AudioSource source;

    bool isReady = true;
    bool startUpdate = false;

    void Start()
    {
        source = GetComponent<AudioSource>();

        if (shuffle == true)
        {
            shuffleAnimator.Play("Shuffle On");
            shuffleAnimatorMini.Play("Shuffle On");
        }

        else
        {
            shuffleAnimator.Play("Shuffle Off");
            shuffleAnimatorMini.Play("Shuffle Off");
        }

        if (repeat == true)
        {
            repeatAnimator.Play("Repeat On");
            repeatAnimatorMini.Play("Repeat On");
        }

        else
        {
            repeatAnimator.Play("Repeat Off");
            repeatAnimatorMini.Play("Repeat Off");
        }
    }

    void Update()
    {
        audioSlider.value = source.time;
        audioSliderMini.value = source.time;

        if (source.isPlaying)
        {
            playPauseAnimator.Play("Pause In");
            playPauseAnimatorMini.Play("Pause In");
        }

        else
        {
            playPauseAnimator.Play("Play In");
            playPauseAnimatorMini.Play("Play In");
        }

        if (startUpdate == true)
        {
            if (clipTimeText.text == clipDurationText.text && shuffle == true && repeat == false)
            {
                source.Stop();
                source.clip = musicList[Random.Range(0, musicList.Length)];
                source.Play();

                isReady = false;
                ShowCurrentTitle();
                tagDisplay.ChangeState();
                StartCoroutine("WaitForMusicEnd");
                audioSlider.maxValue = source.clip.length;
                audioSlider.value = 0;
                audioSliderMini.maxValue = source.clip.length;
                audioSliderMini.value = 0;
            }

            else if (clipTimeText.text == clipDurationText.text && repeat == true && shuffle == false)
            {
                source.Stop();
                audioSlider.value = 0;
                audioSliderMini.value = 0;
                source.Play();
                StartCoroutine("WaitForMusicEnd");
            }

            else if (clipTimeText.text == clipDurationText.text && shuffle == false && repeat == false)
            {
                source.Stop();
                currentTrack++;
                source.clip = musicList[currentTrack];
                source.Play();

                isReady = true;
                tagDisplay.ChangeState();
                ShowCurrentTitle();
                StartCoroutine("WaitForMusicEnd");
                audioSlider.maxValue = source.clip.length;
                audioSlider.value = 0;
                audioSliderMini.maxValue = source.clip.length;
                audioSliderMini.value = 0;
            }

            else if (clipTimeText.text == clipDurationText.text && shuffle == true && repeat == true)
            {
                source.Stop();
                currentTrack++;
                source.clip = musicList[currentTrack];
                source.Play();

                isReady = true;
                tagDisplay.ChangeState();
                ShowCurrentTitle();
                StartCoroutine("WaitForMusicEnd");
                audioSlider.maxValue = source.clip.length;
                audioSlider.value = 0;
                audioSliderMini.maxValue = source.clip.length;
                audioSliderMini.value = 0;
            }
        }
    }

    IEnumerator WaitForMusicEnd()
    {
        while (source.isPlaying)
        {
            playTime = (int)source.time;
            ShowPlayTime();
            yield return null;
        }

        if (isReady == true)
        {
            NextTitle();
            isReady = false;
        }
    }

    public void PlayMusic()
    {
        if (source == null || tempClip == null)
        {
            source.clip = musicList[currentTrack];
        }

        source.Play();

        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
        audioSlider.maxValue = source.clip.length;
        isReady = false;
        startUpdate = true;
    }

    public void PlayCustomMusic(int musicIndex)
    {
        source.Stop();
        currentTrack = musicIndex;

        source.clip = musicList[musicIndex];
        source.Play();

        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
        audioSlider.maxValue = source.clip.length;
        audioSlider.value = 0;
        audioSliderMini.maxValue = source.clip.length;
        audioSliderMini.value = 0;
        startUpdate = true;
    }

    public void PauseMusic()
    {
        source.Pause();
    }

    public void NextTitle()
    {
        nextAnimator.Play("FRPR Animate");
        nextAnimatorMini.Play("FRPR Animate");
        source.Stop();
        currentTrack++;

        if (currentTrack > musicList.Length - 1)
        {
            currentTrack = 0;
        }

        source.clip = musicList[currentTrack];

        if (shuffle == true && repeat == false)
        {
            source.clip = musicList[Random.Range(0, musicList.Length)];
        }

        source.Play();
        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
        audioSlider.maxValue = source.clip.length;
        audioSlider.value = 0;
        audioSliderMini.maxValue = source.clip.length;
        audioSliderMini.value = 0;

        startUpdate = true;
    }

    public void PrevTitle()
    {
        prevAnimator.Play("FRPR Animate");
        prevAnimatorMini.Play("FRPR Animate");
        source.Stop();
        currentTrack--;

        if (currentTrack < 0)
        {
            currentTrack = musicList.Length - 1;
        }

        source.clip = musicList[currentTrack];
        source.Play();

        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
        audioSlider.maxValue = source.clip.length;
        audioSlider.value = 0;
        audioSliderMini.maxValue = source.clip.length;
        audioSliderMini.value = 0;
        startUpdate = true;
    }

    public void StopMusic()
    {
        source.Stop();
        StopCoroutine("WaitForMusicEnd");
    }

    public void MuteMusic()
    {
        source.mute = !source.mute;
    }

    void ShowCurrentTitle()
    {
        fullLength = (int)source.clip.length;
    }

    void ShowPlayTime()
    {
        seconds = playTime % 60;
        minutes = (playTime / 60) % 60;
        clipTimeText.text = minutes + ":" + seconds.ToString("D2");
        clipDurationText.text = ((fullLength / 60) % 60) + ":" + (fullLength % 60).ToString("D2");
        clipTimeTextMini.text = clipTimeText.text;
        clipDurationTextMini.text = clipDurationText.text;
    }

    public void ShuffleAll()
    {
        source.Stop();
        StopCoroutine("WaitForMusicEnd");

        for (int i = 0; i < musicList.Length; i++)
        {
            int rnd = Random.Range(0, musicList.Length);
            tempClip = musicList[rnd];
            musicList[rnd] = musicList[i];
            musicList[i] = tempClip;
        }

        currentTrack = 0;
        source.clip = musicList[currentTrack];
        source.Play();
        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
        audioSlider.maxValue = source.clip.length;
        audioSlider.value = 0;
        audioSliderMini.maxValue = source.clip.length;
        audioSliderMini.value = 0;
    }

    public void MoveSlider()
    {
        source.time = audioSlider.value;
    }

    public void MoveSliderMini()
    {
        source.time = audioSliderMini.value;
    }

    public void Shuffle()
    {
        if (shuffle == true)
        {
            shuffleAnimator.Play("Shuffle Off");
            shuffleAnimatorMini.Play("Shuffle Off");
            shuffle = false;
        }

        else
        {
            shuffleAnimator.Play("Shuffle On");
            shuffleAnimatorMini.Play("Shuffle On");
            shuffle = true;
        }
    }

    public void Repeat()
    {
        if (repeat == true)
        {
            repeatAnimator.Play("Repeat Off");
            repeatAnimatorMini.Play("Repeat Off");
            repeat = false;
        }

        else
        {
            repeatAnimator.Play("Repeat On");
            repeatAnimatorMini.Play("Repeat On");
            repeat = true;
        }
    }
}
