#include<stdio.h>

void Time(int time)
{
	int hour = time / 3600;
	int min = (time / 60) % 60;
	int sec = time % 60;

	printf("%d�� %d�� %d�� �Դϴ�.", hour, min, sec);
}

int main()
{
	int time;
	
	printf("�ð�(�ʴ�����)�� �Է��ϼ���: ");
	scanf_s("%d", &time);
	Time(time);
}


//
//float Meter(float cm) //cm�� m�� ��ȯ
//{
//	return cm / 100;
//}
//
//int main()
//{
//	float cm;
//
//	printf("Ű(cm������) �Է��ϼ���: ");
//	scanf_s("%f", &cm);
//
//	printf("%.3fm�Դϴ�.\n", Meter(cm));
//
//}



//int Add(int n1, int n2)
//{
//	return n1 + n2;
//}
//
//int main()
//{
//	int num1;
//	int num2;
//
//	scanf_s("%d", &num1);
//	scanf_s("%d", &num2);
//	printf("%d",Add(num1, num2));
//}



//void Hello()
//{
//	printf("�ȳ��ϼ���,\n");
//	printf("�ݰ����ϴ�.\n");
//	printf("������ 4�� �Դϴ�.\n");
//}
//
//void PlusTen(int num)
//{
//	printf("%d\n", num + 10);
//}
//int main()
//{
//	PlusTen(30);
//	PlusTen(50);
//	
//}
//float Pi()
//{
//	return 3.141592f;
//}
//int Japangi(int money)
//{
//	printf("���� ���� %d �� �Դϴ�.\n", money);
//	int cost = 500; //���
//	printf("������ ������ %d �� �Դϴ�.\n", cost);
//	int result;
//
//	if (money >= cost)
//	{
//		result = money - cost;
//		printf("���� ���, �ܵ��� %d\n", result);
//	}
//	else
//	{
//		result = money;
//		printf("���� ������, �ܵ��� %d\n", result);
//	}
//	return result;
//}

//void Test(int n1, int n2)
//{
//
//}
//int main()
//{
//	Test(10, 30);


	 /*int money;
	printf("���Ǳ⿡ ���� �ݾ��� �Է� �ϼ���: ");

	scanf_s("%d", &money);

	printf("���� �ܵ���: %d\n", Japangi(money));*/

//}
//
//int main()
//{
//	printf("%f", Pi());
//}