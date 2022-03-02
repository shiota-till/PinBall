using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //スコアの初期値
    private int score = 0;

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
        this.scoreText.GetComponent<Text>().text = "" + score;
        Debug.Log(this.score);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (tag == "SmallStarTag")
        {
            addpoint(10);
        }
        else if (tag == "LargeStarTag")
        {
            addpoint(20);
        }
        else if (tag == "SmallCloudTag") 
        {
            addpoint(20);
        }
        else if (tag == "LargeCloudTag") 
        {
            addpoint(30);
        }
    }
}
