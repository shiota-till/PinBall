using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //スコアの初期値
    private int score = 0;

    //スコアの合計値の関数
    public void addpoint(int point)
    {
        this.score += point;
    }
    //スコアを表示するテキスト
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
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
            addpoint(10);
        }
        if (collision.gameObject.tag == "SmallCloudTag" )
        {
            addpoint(15);
        }
        if (collision.gameObject.tag == "LargeStarTag")
        {
            addpoint(20);
        }
        if (collision.gameObject.tag == "LargeCloudTag")
        {
            addpoint(100);
        }
    }
}
