using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NavMeshAgent���Ăяo���̂ɕK�v��Import
using UnityEngine.AI;

public class Enemy : MonoBehaviour
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
    /// �v���C���[�̃g�����X�t�H�[��
    /// </summary>
    public Transform player;

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
        // �v���C���[�̈ړ�����w��
        navMeshAgent.destination = player.position;

        // �A�j���[�^�[�R���g���[���[�ɒǉ������p�����[�^��
        // �������Ŏw�肵���l������
        animator.SetFloat("velocity", navMeshAgent.velocity.magnitude);
    }
}
