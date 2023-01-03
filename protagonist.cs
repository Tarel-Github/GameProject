using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;



//===============================================캐릭터 에니메이션 저장공간   시작
public class PlayerAnim//왼쪽은 변수가아닌 플레이어 에니메이션 실행 함수
{
    public AnimationClip idle;
    public AnimationClip runF;
    public AnimationClip runB;
    public AnimationClip runL;
    public AnimationClip runR;
}
//===============================================캐릭터 에니메이션 저장공간   끝


public class PlayerCtrl : MonoBehaviour
{
    //필요한 변수목록
    private float h = 0.0f;
    private float v = 0.0f;
    private float r = 0.0f;


    private float moveSpeed = 10.0f;                //이동속도
    private float actSpeed = 10.0f;                 //행동속도
    private string status_active = "idle";
    //상태 walk, run, dodge, act, faint, down
    private string status_passive= "normal"
    //상태 normal, hit
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

    // 접근해야 하는 컴포넌트는 반드시 변수에 할당한 후 사용
    [SerializeField] private Transform tr;// 왼쪽 대괄호는 Debug모드가 아닌 인스펙터에서 private 변수를 노출하게 하는 기능이다. private속성(타클래스의 접근 불허)은 유지된다.



    public float moveSpeed = 10.0f;// 이동 속도 변수 public으로 선언되어 Inspector에 노출됨
    public float rotSpeed = 80.0f;// 회전 속도 변수



    public PlayerAnim playerAnim;// Inspector 뷰에 표시할 애니메이션 클래스 변수
    public Animation anim;// Animation 컴포넌트를 저장하기 위한 변수

//======================================================================
private float totalPositive = 0f;
private float totalNegative = 0f;
private float facePositive = 0f;    //가벼운 긍정적인 심정, 양수면 단순히 기분좋음, 음수면
private float deepPositive = 0f;    //깊은 긍정적인 심정, 절대값이 크면 성격이나 대상에 대한 인식이 크게 반영됌, 양수면 은혜감정이 생김, 음수면 배신감을 느낌
private float faceNegative = 0f;    //가벼운 부정적인 심정, 양수면 단순히 짜증남, 음수면 기분은 나쁘나 화내기 어려운 상황
private float deepNegative = 0f;    //깊은 부정적인 심정, 절대값이 크면 성격이나 대상에 대한 인식이 크게 반영됌, 양수면 증오나 원한이 생김, 음수면 용서함
private float forWho = 0f;          //양수는 이타적, 음수는 이기적
private float greed = 0f;           //욕심지수, 양수면 가까이하고 싶고 음수면 멀리 하고 싶음,
private float act = 0f;             //행동지수, 양수면 능동적, 음수면 수동적

private int countForWhoUp = 0;      //이타적이었던 횟수
private int countForWhoDown = 0;    //이기적이었던 횟수



//클래스 미리 복사해두기
class Terran
{
    protected int _HP;
    protected int _ATK;
    protected int _Speed;
    protected int _Cost;
    public virtual void Run()
    {
        Console.Write("{0}의 속도로 ", _Speed);
    }

    public virtual void Attack()
    {
        Console.WriteLine();

        if (this is FireBat)
        {
            Console.Write("근거리 공격력: {0} ", _ATK);
        }
        else
        {
            Console.Write("원거리 공격력: {0} ", _ATK);
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
        Console.WriteLine("마린이 달린다.");
    }

    public override void Attack()
    {
        base.Attack();

        Console.WriteLine("마린의 총격! ");
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
        Console.WriteLine("파뱃이 달린다.");
    }

    public override void Attack()
    {
        base.Attack();
        Console.WriteLine("파뱃의 화염공격! ");
    }
}





void Start()
    {

    }


    void Update()
    {
     
    }
}
