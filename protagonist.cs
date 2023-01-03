using System;
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
    //�ʿ��� �������
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

//======================================================================
private float totalPositive = 0f;
private float totalNegative = 0f;
private float facePositive = 0f;    //������ �������� ����, ����� �ܼ��� �������, ������
private float deepPositive = 0f;    //���� �������� ����, ���밪�� ũ�� �����̳� ��� ���� �ν��� ũ�� �ݿ���, ����� ���������� ����, ������ ��Ű��� ����
private float faceNegative = 0f;    //������ �������� ����, ����� �ܼ��� ¥����, ������ ����� ���ڳ� ȭ���� ����� ��Ȳ
private float deepNegative = 0f;    //���� �������� ����, ���밪�� ũ�� �����̳� ��� ���� �ν��� ũ�� �ݿ���, ����� ������ ������ ����, ������ �뼭��
private float forWho = 0f;          //����� ��Ÿ��, ������ �̱���
private float greed = 0f;           //�������, ����� �������ϰ� �Ͱ� ������ �ָ� �ϰ� ����,
private float act = 0f;             //�ൿ����, ����� �ɵ���, ������ ������

private int countForWhoUp = 0;      //��Ÿ���̾��� Ƚ��
private int countForWhoDown = 0;    //�̱����̾��� Ƚ��



//Ŭ���� �̸� �����صα�
class Terran
{
    protected int _HP;
    protected int _ATK;
    protected int _Speed;
    protected int _Cost;
    public virtual void Run()
    {
        Console.Write("{0}�� �ӵ��� ", _Speed);
    }

    public virtual void Attack()
    {
        Console.WriteLine();

        if (this is FireBat)
        {
            Console.Write("�ٰŸ� ���ݷ�: {0} ", _ATK);
        }
        else
        {
            Console.Write("���Ÿ� ���ݷ�: {0} ", _ATK);
        }
    }
}

class Marine : Terran
{
    public Marine()
    {
        _HP = 40;
        _ATK = 6;
        _Speed = 100;
        _Cost = 50;
    }

    public override void Run()
    {
        base.Run();
        Console.WriteLine("������ �޸���.");
    }

    public override void Attack()
    {
        base.Attack();

        Console.WriteLine("������ �Ѱ�! ");
    }
}

class FireBat : Terran
{
    public FireBat()
    {
        _HP = 50;
        _ATK = 16;
        _Speed = 100;
        _Cost = 75;
    }

    public override void Run()
    {
        base.Run();
        Console.WriteLine("�Ĺ��� �޸���.");
    }

    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("�Ĺ��� ȭ������! ");
    }
}





void Start()
    {

    }


    void Update()
    {
     
    }
}
