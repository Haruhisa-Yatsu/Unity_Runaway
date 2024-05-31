using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshAgent���Ăяo���̂ɕK�v��Import
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    /// <summary>
    /// �i�r���b�V���R���|�[�l���g
    /// </summary>
    public NavMeshAgent navMeshAgent;

    /// <summary>
    /// �ړ��̑���
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
        // �v���C���[�̃��[���h���W���擾
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

        // �w�肵�����W�������Ă����
        transform.LookAt(pos + move);
        // �v���C���[�̈ړ�����w��
        navMeshAgent.nextPosition += _velocity * move.normalized * Time.deltaTime;

    }
}
