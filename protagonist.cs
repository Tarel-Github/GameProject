using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;



//===============================================ĳ���� ���ϸ��̼� �������   ����
public class PlayerAnim//������ �������ƴ� �÷��̾� ���ϸ��̼� ���� �Լ�
{
    public AnimationClip idle;
    public AnimationClip runF;
    public AnimationClip runB;
    public AnimationClip runL;
    public AnimationClip runR;
}
//===============================================ĳ���� ���ϸ��̼� �������   ��


public class PlayerCtrl : MonoBehaviour
{
    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;

    private float moveSpeed = 10.0f;                //�̵��ӵ�
    private float actSpeed = 10.0f;                 //�ൿ�ӵ�
    private string status_active = "idle";
    //���� walk, run, dodge, act, faint, down
    private string status_passive= "normal"
    //���� normal, hit
    private void skill = { }

    private string weapon1;
    private string weapon2;

    private void boneSword =
    {
        private string name = "BoneSword";
        private string type = "meleeAttack";
        private int ATK = 10;
        private float RPD = 1.0f;
        private float Length = 1.0f;
    }

    // �����ؾ� �ϴ� ������Ʈ�� �ݵ�� ������ �Ҵ��� �� ���
    [SerializeField] private Transform tr;// ���� ���ȣ�� Debug��尡 �ƴ� �ν����Ϳ��� private ������ �����ϰ� �ϴ� ����̴�. private�Ӽ�(ŸŬ������ ���� ����)�� �����ȴ�.



    public float moveSpeed = 10.0f;// �̵� �ӵ� ���� public���� ����Ǿ� Inspector�� �����
    public float rotSpeed = 80.0f;// ȸ�� �ӵ� ����



    public PlayerAnim playerAnim;// Inspector �信 ǥ���� �ִϸ��̼� Ŭ���� ����
    public Animation anim;// Animation ������Ʈ�� �����ϱ� ���� ����


    void Start()
    {

    }


    void Update()
    {
      
    }
}
