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
        //�t���[�����[�g�̐ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            this.rotspeed = 10;
            //��]���x�̑��
        }

        transform.Rotate(0, 0, this.rotspeed);
        //Z������ɉ�]������

        this.rotspeed *= 0.98f;
        //����

    }
}
