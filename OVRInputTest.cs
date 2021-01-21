using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class OVRInputTest : MonoBehaviour
{
    public Texture photo1;
    public Texture photo2;
    public Texture photo3;
    public Texture photo4;
    public Texture R1;

    /** 利き手に持った方のコントローラー **/
public OVRInput.Controller dominantHandController;

/** 利き手ではない手に持った方のコントローラー **/
public OVRInput.Controller otherHandController;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = photo2;
    }

    // Update is called once per frame
    void Update()
    {
        //右手のAボタンを押すとphoto1の画像に切り替わる
        if (OVRInput.GetDown(OVRInput.RawButton.A))
    {
        GetComponent<Renderer>().material.mainTexture = photo1;
    }
        //右手のBボタンを押すとphoto2の画像に切り替わる
    if (OVRInput.GetDown(OVRInput.RawButton.B))
    {
        GetComponent<Renderer>().material.mainTexture = photo3;
    }
        //左手のXボタンを押すとphoto2に切り替わる
    if (OVRInput.GetDown(OVRInput.RawButton.X))
    {
        GetComponent<Renderer>().material.mainTexture = photo2;
    }

     //左手のyボタンを押すとphoto2に切り替わる
    if (OVRInput.GetDown(OVRInput.RawButton.Y))
    {
        GetComponent<Renderer>().material.mainTexture = photo4;
    }
        //動画再生
    // if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
    // {
    //      GetComponent<Renderer>().material.mainTexture = photo4;

    // }
        // 右手のAボタンが押された時に画像を変換(02→01)
    //     if (OVRInput.GetDown(OVRInput.Button.One)) {
    //         GetComponent<Renderer>().material.mainTexture = photo1;
        
    // }
    // if (OVRInput.GetDown(OVRInput.Button.One, dominantHandController)) {
    //     // 利き手のコントローラーのボタン（AまたはX）が押された時の処理
    // }
    // 利き手ではないコントローラーのボタン（AまたはX）が押された時の処理
    // if (OVRInput.GetDown(OVRInput.Button.One, otherHandController)) {
    //     GetComponent<Renderer>().material.mainTexture = photo1;
    // }

    }
}
