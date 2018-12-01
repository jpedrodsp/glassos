using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Music Tag", menuName = "Music Player/New Music Tag")]
public class MusicTag : ScriptableObject {

    public string songName;
    public string artistName;
    public Sprite artwork;
}
