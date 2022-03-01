using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HIngeJointコンポーネントを入れる
    private HingeJoint myHingejoint;

    //初期の傾き
    private float defaultltAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;


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
        //左矢印キーを押した時、左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") 
        {
            SetAngle(this.flickAngle);
        }
        //右矢印キーを押した時、右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") 
        {
            SetAngle(this.flickAngle);
        }

        //矢印キーが離された時、フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag") 
        {
            SetAngle(this.defaultltAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag") 
        {
            SetAngle(this.defaultltAngle);
        }
    }
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingejoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingejoint.spring = jointSpr;
    }
}
