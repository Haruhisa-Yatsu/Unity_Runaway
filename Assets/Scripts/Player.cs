using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshAgentを呼び出すのに必要なImport
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    /// <summary>
    /// ナビメッシュコンポーネント
    /// </summary>
    public NavMeshAgent navMeshAgent;

    /// <summary>
    /// 移動の速さ
    /// </summary>
    public float _velocity = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        // プレイヤーのワールド座標を取得
        Vector3 pos = transform.position;

        // vector3(0,0,0);
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            move += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move -= Vector3.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move -= Vector3.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }

        // 指定した座標を向いてくれる
        transform.LookAt(pos + move);
        // プレイヤーの移動先を指定
        navMeshAgent.nextPosition += _velocity * move.normalized * Time.deltaTime;

    }
}
