//MonoBehaviour ����ϱ� ���ؼ�
using UnityEngine;
//TextMeshProUGUI ����ϱ� ���ؼ�
using TMPro;

public class Gamemanager : MonoBehaviour
{
    enum eRsp
    {
        rock,
        si,
        paper
    }


    //�ؽ�Ʈ ���� ����
    //�ۻ���(UI�� text)�� ���� �����ϱ� ���ؼ�
    //public -> �������: inspector���� ������ ���� �ʱ�ȭ�ϱ� ���ؼ�
    public TextMeshProUGUI meText; //���� �� �´���
    public TextMeshProUGUI comText; //���� �� �ߴ���
    public TextMeshProUGUI scoreText; //�¹���
    public TextMeshProUGUI wdlText; //����

    //0 1 2�� ������ ���� ����
    //�迭�� �ε����� Ȱ���� ���� 0 1 2�� ������ ����
    int me; //���� �� �´��� �����ϱ� ����
    int com; //���� �� �´��� �����ϱ� ����
    int wdl; //�¹��� ������ ����
    int score = 0; 

    //�ε����� Ȱ���ϱ� ����
    //me ������ com ������ Ȱ���� ���� 
    //0 = R
    //1 = S
    //2 = P
    //me �� com �Ѵ� ����ϴ�
    //�ε����� ���� ���� ����
    string[] rsp =
    {
        "R","S","P"
    };

    //���ǹ����� ���ؼ�
    //���ǹ� ���� if�� 3�� ��������.(�ڵ尡 �����)
    //0 = Lose
    //1 = Draw
    //2 = Win
    string[] wdlArr = 
    {
        "Lose","Draw","Win"
    };

    //me �� com�� ���� ����
    //1 win
    //0 draw
    //-1 lose
    int[,] results = //����� �迭�Լ�
    {
        {0,1,-1},
        {-1,0,1},
        {1,-1,0}
    };

    //��ư Ŭ���� ������ �Լ�
    //Ŭ���� ��ư���� ���� ������ ����
    public void R()
    {
        me = (int)eRsp.rock;
        //me = rock; //���� ���� ����
        ComChoice();
    }
    public void S()
    {
        me = 1; //���� ���� ����
        ComChoice();
    }
    public void P()
    {
        me = 2; //���� ���� ��
        ComChoice();
    }

    //������̸�
    public void RSP(int rsp)
    {
        me = rsp;
        ComChoice();
    }

    //��ǻ�Ͱ� ������ ���������� �����ϴ� �Լ�
    private void ComChoice() //�İ�(����) �Լ�
    {
        //��ǻ���� ���������� ����
        //range(inclusive,exclusive)
        com = Random.Range(0, 3); //0,1,2

        //���� ������ ȭ��� ǥ��
        //rsp[me] ���� ���Ϳ� ���� ���������� ��ȯ
        meText.text = rsp[me];
        //���� ������ ȭ��� ǥ��
        comText.text = rsp[com];

        //�¹��� ����
        WdlSet();
    }

    /// <summary>
    /// �� �� ��
    /// win
    /// draw
    /// lose
    /// </summary>
    private void WdlSet() //�¹����Լ�
    {
        //results �迭�� ���� ���Ͱ� ���� ���� Ȱ���Ͽ�
        //-1 0 1 �� ��ȯ
        wdl = results[me, com];

        //���� ���� ȭ��� ǥ��
        //wdl �� ���� -1 0 1
        //1�� ���ϸ�   0 1 2 
        //���Ѱ��� �ε����� Ȱ���ϱ� ���� +1��.
        wdlText.text = wdlArr[wdl + 1]; //�¹����Լ�

        //������ �¹��п� ���� ����
        score += wdl;

        //������ ȭ��� ǥ��
        //.ToString() �������
        //scoreText.text �ڷ��� string
        //score �ڷ��� int
        //���� �ڷ����� �ٸ�
        //�ʱ�ȭ �ϰ���� �ڷ�� string
        //���� string���� �ٲٱ� ���� ���
        scoreText.text = score.ToString();
    }

}
