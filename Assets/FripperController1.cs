using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController1 : MonoBehaviour
{
    //HIngeJointコンポーネントを入れる
    private HingeJoint myHingejoint;

    //初期の傾き
    private float defaultltAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    //左フリッパーの関数
    void FrickL(int a)
    {
        if (a < 1)
        {
            if (tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            }
        }
        if (a >= 1)
        {
            if (tag == "LeftFripperTag")
            {
                SetAngle(this.defaultltAngle);
            }
        }
    }
    //右フリッパーの関数
    void FrickR(int b)
    {
        if (b < 1)
        {
            if (tag == "RightFripperTag")
            {
                SetAngle(this.flickAngle);
            }
        }
        if (b >= 1)
        {
            if (tag == "RightFripperTag")
            {
                SetAngle(this.defaultltAngle);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネントを取得
        this.myHingejoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultltAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印またはAキーを押した時、左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow)
            ||
            Input.GetKeyDown(KeyCode.DownArrow)
            ||
            Input.GetKeyDown(KeyCode.A) 
            ||
            Input.GetKeyDown(KeyCode.S))
        {
            FrickL(0);
        }
        //右矢印またはDキーを押した時、右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow)
            ||
            Input.GetKeyDown(KeyCode.DownArrow)
            ||
            Input.GetKeyDown(KeyCode.D)
            ||
            Input.GetKeyDown(KeyCode.S))
        {
            FrickR(0);
        }

        //押したキーが離された時、フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) 
            ||
            Input.GetKeyUp(KeyCode.RightArrow)
            ||
            Input.GetKeyUp(KeyCode.DownArrow)
            ||
            Input.GetKeyUp(KeyCode.DownArrow)
            ||
            Input.GetKeyUp(KeyCode.A)
            ||
            Input.GetKeyUp(KeyCode.D)
            ||
            Input.GetKeyUp(KeyCode.S)
            ||
            Input.GetKeyUp(KeyCode.S))
        {
            FrickL(1);
            FrickR(1);
        }
    }
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingejoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingejoint.spring = jointSpr;
    }
}
