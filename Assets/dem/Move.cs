using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
          // rigidbodyを取得
        Vector2 force = new Vector3(-2.0f, 0.0f);    // 力を設定
        rb.AddForce(force);  // 力を加える
    }
}
