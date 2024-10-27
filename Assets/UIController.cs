using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    //ゲームオーバーテキスト
    private GameObject gameOverText;

    //走行距離テキスト
    private GameObject runDistanceText;

    //再開方法テキスト
    private GameObject restartText;

    //走った距離
    private float distance = 0;

    //走る速度
    private float speed = 5f;

    //ゲームオーバーの判定
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        //シーンビューからオブジェクトの実態を検索する
        this.gameOverText = GameObject.Find("GameOver");
        this.runDistanceText = GameObject.Find("RunDistance");
        this.restartText = GameObject.Find("Restart");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            //走った距離を更新する
            this.distance += this.speed * Time.deltaTime;

            //走った距離を表示する
            this.runDistanceText.GetComponent<Text>().text = ("Distance: " + distance.ToString("F2") + "m");
        }

        if(this.isGameOver == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                //SampleSceneを読み込む
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        //ゲームオーバーになった時に、画面上にゲームオーバー表示する
        this.gameOverText.GetComponent<Text>().text = ("Game Over");
        this.restartText.GetComponent<Text>().text = ("Restart\nwith a Click of the Left Mouse Button");
        this.isGameOver = true;
    }
}
