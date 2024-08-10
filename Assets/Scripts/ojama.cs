using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojama : MonoBehaviour
{
    float speed = 0.05f;

    float defaultPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x + speed;
        if (x > defaultPos + 27.0f || x < defaultPos - 5.0f)
        {
            speed *= -1;
        }
        transform.position = new Vector3(x, transform.position.y,
            transform.position.z);
    }

    //‚±‚±‚ÉˆÚ“®‚ÌƒvƒƒOƒ‰ƒ€‚ð‘‚«‚Ü‚µ‚å‚¤

}
