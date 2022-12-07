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


    void Start()
    {

    }


    void Update()
    {
      
    }
}
