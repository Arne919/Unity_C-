//MonoBehaviour 사용하기 위해서
using UnityEngine;
//TextMeshProUGUI 사용하기 위해서
using TMPro;

public class Gamemanager : MonoBehaviour
{
    enum eRsp
    {
        rock,
        si,
        paper
    }


    //텍스트 변수 선언
    //글상자(UI의 text)에 대해 접근하기 위해서
    //public -> 사용이유: inspector에서 변수에 대해 초기화하기 위해서
    public TextMeshProUGUI meText; //내가 뭘 냈는지
    public TextMeshProUGUI comText; //컴이 뭘 했는지
    public TextMeshProUGUI scoreText; //승무패
    public TextMeshProUGUI wdlText; //점수

    //0 1 2로 범위를 잡은 이유
    //배열의 인덱스로 활용을 위해 0 1 2로 범위를 잡음
    int me; //내가 뭘 냈는지 저장하기 위해
    int com; //컴이 뭘 냈는지 저장하기 위해
    int wdl; //승무패 뭐인지 저장
    int score = 0; 

    //인덱스를 활용하기 위해
    //me 변수와 com 변수의 활용을 위해 
    //0 = R
    //1 = S
    //2 = P
    //me 와 com 둘다 사용하니
    //인덱스에 따른 값을 만듦
    string[] rsp =
    {
        "R","S","P"
    };

    //조건문보다 편해서
    //조건문 사용시 if문 3개 만들어야함.(코드가 길어짐)
    //0 = Lose
    //1 = Draw
    //2 = Win
    string[] wdlArr = 
    {
        "Lose","Draw","Win"
    };

    //me 와 com의 값에 따라
    //1 win
    //0 draw
    //-1 lose
    int[,] results = //결과값 배열함수
    {
        {0,1,-1},
        {-1,0,1},
        {1,-1,0}
    };

    //버튼 클릭시 실행할 함수
    //클릭한 버튼으로 내가 낸것을 설정
    public void R()
    {
        me = (int)eRsp.rock;
        //me = rock; //내가 낸건 바위
        ComChoice();
    }
    public void S()
    {
        me = 1; //내가 낸건 가위
        ComChoice();
    }
    public void P()
    {
        me = 2; //내가 낸건 보
        ComChoice();
    }

    //↓↓줄이면
    public void RSP(int rsp)
    {
        me = rsp;
        ComChoice();
    }

    //컴퓨터가 랜덤한 가위바위보 결정하는 함수
    private void ComChoice() //컴값(랜덤) 함수
    {
        //컴퓨터의 가위바위보 설정
        //range(inclusive,exclusive)
        com = Random.Range(0, 3); //0,1,2

        //내가 낸것을 화면상에 표시
        //rsp[me] 내가 낸것에 따른 가위바위보 반환
        meText.text = rsp[me];
        //내가 낸것을 화면상에 표시
        comText.text = rsp[com];

        //승무패 설정
        WdlSet();
    }

    /// <summary>
    /// 승 무 패
    /// win
    /// draw
    /// lose
    /// </summary>
    private void WdlSet() //승무패함수
    {
        //results 배열에 내가 낸것과 컴이 낸것 활용하여
        //-1 0 1 을 반환
        wdl = results[me, com];

        //컴이 낸걸 화면상에 표시
        //wdl 값 범위 -1 0 1
        //1씩 더하면   0 1 2 
        //더한값을 인덱스로 활용하기 위해 +1함.
        wdlText.text = wdlArr[wdl + 1]; //승무패함수

        //점수를 승무패에 대해 누적
        score += wdl;

        //점수를 화면상에 표시
        //.ToString() 사용이유
        //scoreText.text 자료형 string
        //score 자료형 int
        //서로 자료형이 다름
        //초기화 하고싶은 자료는 string
        //값을 string으로 바꾸기 위해 사용
        scoreText.text = score.ToString();
    }

}
