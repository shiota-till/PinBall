using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //�X�R�A�̏����l
    private int score = 0;

    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    //�^�[�Q�b�g�̃X�R�A
    private int[] points = { 5, 10, 20 };

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "SmallStarTag")
        {
            //this.score += this.points[0];
            Debug.Log(this.score);
        }
        else if (tag == "LargeStarTag" || tag == "SmallCloudTag")
        {
            //this.score += this.points[1];
            Debug.Log(this.score);
        }
        else if (tag == "LargeCloudTag")
        {
            //this.score += this.points[2];
            Debug.Log(this.score);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        
    }
}
