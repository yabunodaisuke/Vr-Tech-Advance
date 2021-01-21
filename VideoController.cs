using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoController : MonoBehaviour
{
    /// <summary>
    /// 制御するVideo Playerのリスト
    /// </summary>
    [SerializeField]
    private List<VideoPlayer> playerList;
    /// <summary>
    /// 再生
    /// </summary>
    public void Play()
    {
        foreach(VideoPlayer player in playerList)
        {
            if (!player.isPlaying)
            {
                player.Play();
            }
        }
    }
}
