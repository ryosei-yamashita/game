using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roulette_controller : MonoBehaviour
{
    float rotspeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //フレームレートの設定
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            this.rotspeed = 10;
            //回転速度の代入
        }

        transform.Rotate(0, 0, this.rotspeed);
        //Z軸周りに回転させる

        this.rotspeed *= 0.98f;
        //減速

    }
}
