using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController1 : MonoBehaviour
{
    //HIngeJoint�R���|�[�l���g������
    private HingeJoint myHingejoint;

    //�����̌X��
    private float defaultltAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;

    //���t���b�p�[�̊֐�
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
    //�E�t���b�p�[�̊֐�
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
        //HingeJoint�R���|�[�l���g���擾
        this.myHingejoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultltAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //�����܂���A�L�[�����������A���t���b�p�[�𓮂���
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
        //�E���܂���D�L�[�����������A�E�t���b�p�[�𓮂���
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

        //�������L�[�������ꂽ���A�t���b�p�[�����ɖ߂�
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
