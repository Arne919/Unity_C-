#include<stdio.h>

int main(void)
{

	float kor;
	float eng;
	float math;

	printf("���������� �Է��ϼ���: ");
	scanf_s("%f", &kor);
	printf("���������� �Է��ϼ���: ");
	scanf_s("%f", &eng);
	printf("���������� �Է��ϼ���: ");
	scanf_s("%f", &math);

	int avg = (kor + eng + math) / 3;
	printf("��� ���� : %d ", avg);


	switch (avg / 10)
	{
	case 10:
	case 9:
		printf("\n����: A");
		break;
	case 8:
		printf("\n����: B");
		break;
	case 7:
		printf("\n����: C");
		break;
	case 6:
		printf("\n����: D");
		break;
	default:
		printf("\n����: F");
		break;
	}







	//int num;

	//printf("1 ~ 10 ������ ���ڸ� �Է��ϼ���: ");
	//scanf_s("%d", &num);

	//switch (num%2)
	//{
	//case 0:
	//	printf("¦��");
	//	break;

	//default:
	//	printf("Ȧ��");
	//	break;

	//}


	//int num = 7;

	//switch (num)
	//{
	//case 0:
	//	printf("num���� 0");
	//	break;

	//case 1:
	//	printf("num���� 1");
	//	break;

	//case 2:
	//	printf("num���� 2");
	//	break;

	//default:
	//	break;
	//}



	//float kor;
	//float eng;
	//float math;

	//printf("���������� �Է��ϼ���: ");
	//scanf_s("%f", &kor);
	//printf("���������� �Է��ϼ���: ");
	//scanf_s("%f", &eng);
	//printf("���������� �Է��ϼ���: ");
	//scanf_s("%f", &math);

	//float avg = (kor + eng + math) / 3;
	//printf("%0.0f", avg);
	//if (avg >= 90)
	//	printf("\n����� �����: A");
	//else if (avg >= 80)
	//{
	//	printf("\n����� �����: B");
	//}
	//else if (avg >= 70)
	//{
	//	printf("\n����� �����: C");
	//}
	//else if (avg >= 60)
	//{
	//	printf("\n����� �����: D");
	//}
	//else
	//{
	//	printf("\n����� �����: F");
	//}



	//int money;

	//printf("�ݾ��� �Է��ϼ���: ");
	//scanf_s("%d", &money);

	//if (money >= 10000)
	//{
	//	printf("����");
	//}
	//else if (money >= 5000)
	//{
	//	printf("���ö�");
	//}
	//else
	//{
	//	printf("�ﰢ���");
	//}



	//float cm;
	//int age;

	//printf("Ű�� �Է��ϼ���: ");
	//scanf_s("%f", &cm);
	//printf("���̸� �Է��ϼ���: ");
	//scanf_s("%d", &age);

	//if (cm >=130 && age > 6)
	//{
	//	printf("ž�°����մϴ�.");
	//}
	//else
	//{
	//	printf("ž�� �Ұ����մϴ�.");
	//}
}