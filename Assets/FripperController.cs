using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HIngeJoint�R���|�[�l���g������
    private HingeJoint myHingejoint;

    //�����̌X��
    private float defaultltAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;


    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g���擾
        this.myHingejoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultltAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //�����܂���A�L�[�����������A���t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag"
            ||
            Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag"
            ||
            Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag"
            ||
            Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag") 
        {
            SetAngle(this.flickAngle);
        }
        //�E���܂���D�L�[�����������A�E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag"
            ||
            Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag"
            ||
            Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag"
            ||
            Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag") 
        {
            SetAngle(this.flickAngle);
        }

        //�������L�[�������ꂽ���A�t���b�p�[�����ɖ߂�
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag"
            ||
            Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag"
            ||
            Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag"
            ||
            Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag"
            ||
            Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag"
            ||
            Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag"
            ||
            Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag"
            ||
            Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag")
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
