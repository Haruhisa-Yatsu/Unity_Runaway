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
    /// �A�j���[�^�[�R���|�[�l���g
    /// </summary>
    public Animator animator;

    /// <summary>
    /// �����̑���
    /// </summary>
    public float _velocity = 3.0f;

    /// <summary>
    /// ����̑���
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
        // �v���C���[�̃��[���h���W���擾
        Vector3 pos = transform.position;

        // vector3(0,0,0);
        Vector3 move = Vector3.zero;

        float velocity = _velocity;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velocity = _sprintVelocity;
        }


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
        navMeshAgent.nextPosition += velocity * move.normalized * Time.deltaTime;

        // �A�j���[�^�[�R���g���[���[�ɒǉ������p�����[�^��
        // �������Ŏw�肵���l������
        animator.SetFloat("velocity", move.normalized.magnitude * velocity);
    }
}
