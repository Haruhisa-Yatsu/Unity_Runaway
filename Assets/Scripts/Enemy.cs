using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshAgentを呼び出すのに必要なImport
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// ナビメッシュコンポーネント
    /// </summary>
    public NavMeshAgent navMeshAgent;

    /// <summary>
    /// アニメーターコンポーネント
    /// </summary>
    public Animator animator;

    /// <summary>
    /// プレイヤーのトランスフォーム
    /// </summary>
    public Transform player;

    /// <summary>
    /// 歩きの速さ
    /// </summary>
    public float _velocity = 3.0f;

    /// <summary>
    /// 走りの速さ
    /// </summary>
    public float _sprintVelocity = 6.0f;

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
        // プレイヤーの移動先を指定
        navMeshAgent.destination = player.position;

        // アニメーターコントローラーに追加したパラメータへ
        // 第二引数で指定した値を入れる
        animator.SetFloat("velocity", navMeshAgent.velocity.magnitude);
    }
}
