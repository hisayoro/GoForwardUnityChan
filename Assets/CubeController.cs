using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12;

    //消滅位置
    private float deadLine = -10;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < deadLine)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //キューブが積みあがった時に音を出す。Unityちゃんとの接触時は出さない
        //if(collision.gameObject.tag == "CubeTag" || collision.gameObject.name == "ground")
        if(collision.gameObject.name != "UnityChan2D")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
