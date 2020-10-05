using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoveUI : MonoBehaviour
{
    //プレイヤーのスピード
    [SerializeField]
    private float speed = 0.0f;

    //プレイヤーの角度
    [SerializeField]
    private float angle = 0.0f;

    //プレイヤー
    [SerializeField]
    GameObject player;

    //右ボタンを押しているかの判定
    private bool right = false;

    //左ボタンを押しているかの判定
    private bool left = false;

    //上ボタンを押しているかの判定
    private bool top = false;

    //下ボタンを押しているかの判定
    private bool bottom = false;

    //private bool jumpFlag = false;

    //private Rigidbody rigidbody;

    //[SerializeField]
    //private float jumpPower;

    void Update()
    {
        if (right)
        {
            //右旋回ためのメソッドを呼び出す
            GoRight();
        }
        else if (left)
        {
            //左旋回動かすためのメソッドを呼び出す
            GoLeft();
        }
        else if(top)
        {
            //前に進むためのメソッドを呼び出す
            GoTop();
        }
        else if(bottom)
        {
            //後ろに下がるためのメソッドを呼び出す
            GoBottom();
        }

    }

    //ジャンプボタンを押したらジャンプ
    //public void JumpClick()
    //{
    //    if (!jumpFlag)
    //    {
    //        rigidbody.AddForce(transform.up * jumpPower);
    //        jumpFlag = true;
    //    }
    //}

    public void RPushDown()
    {
        //右ボタンを押している間
        right = true;
    }

    public void RPushUp()
    {
        //右ボタンを押すのをやめた時
        right = false;
    }

    public void LPushDown()
    {
        //左ボタンを押している間
        left = true;
    }

    public void LPushUp()
    {
        //左ボタンを押すのをやめた時
        left = false;
    }

    public void TPushDown()
    {
        //上ボタンを押している間
        top = true;
    }

    public void TPushUp()
    {
        //上ボタンを押すのをやめた時
        top = false;
    }

    public void BPushDown()
    {
        //下ボタンを押している間
        bottom = true;
    }

    public void BPushUp()
    {
        //下ボタンを押すのをやめた時
        bottom = false;
    }

    public void GoRight()
    {
        //プレイヤーの回転
        player.transform.Rotate(new Vector3(0, angle, 0));
    }

    public void GoLeft()
    {
        //プレイヤーの回転
        player.transform.Rotate(new Vector3(0, -angle, 0));
    }

    public void GoTop()
    {
        //プレイヤーの回転
        player.transform.Translate(0f, 0f, speed);
    }

    public void GoBottom()
    {
        //プレイヤーの回転
        player.transform.Translate(0f, 0f, -speed);
    }
}
