using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    //�Q�[���I�[�o�[�e�L�X�g
    private GameObject gameOverText;

    //���s�����e�L�X�g
    private GameObject runDistanceText;

    //�ĊJ���@�e�L�X�g
    private GameObject restartText;

    //����������
    private float distance = 0;

    //���鑬�x
    private float speed = 5f;

    //�Q�[���I�[�o�[�̔���
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[���r���[����I�u�W�F�N�g�̎��Ԃ���������
        this.gameOverText = GameObject.Find("GameOver");
        this.runDistanceText = GameObject.Find("RunDistance");
        this.restartText = GameObject.Find("Restart");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            //�������������X�V����
            this.distance += this.speed * Time.deltaTime;

            //������������\������
            this.runDistanceText.GetComponent<Text>().text = ("Distance: " + distance.ToString("F2") + "m");
        }

        if(this.isGameOver == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                //SampleScene��ǂݍ���
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        //�Q�[���I�[�o�[�ɂȂ������ɁA��ʏ�ɃQ�[���I�[�o�[�\������
        this.gameOverText.GetComponent<Text>().text = ("Game Over");
        this.restartText.GetComponent<Text>().text = ("Restart\nwith a Click of the Left Mouse Button");
        this.isGameOver = true;
    }
}
