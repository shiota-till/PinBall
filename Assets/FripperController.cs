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
        //�����L�[�����������A���t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") 
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[�����������A�E�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") 
        {
            SetAngle(this.flickAngle);
        }

        //���L�[�������ꂽ���A�t���b�p�[�����ɖ߂�
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
