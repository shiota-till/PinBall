using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //�X�R�A�̏����l
    private int score = 0;

    //�X�R�A�̍��v�l�̊֐�
    public void Totalpoint(int point)
    {
        this.score += point;
    }
    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SmallStarTag")
        {
            Totalpoint(10);
        }
        if (collision.gameObject.tag == "SmallCloudTag" )
        {
            Totalpoint(15);
        }
        if (collision.gameObject.tag == "LargeStarTag")
        {
            Totalpoint(20);
        }
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            Totalpoint(100);
        }
    }
}
