#include<stdio.h>

void Time(int time)
{
	int hour = time / 3600;
	int min = (time / 60) % 60;
	int sec = time % 60;

	printf("%d시 %d분 %d초 입니다.", hour, min, sec);
}

int main()
{
	int time;
	
	printf("시간(초단위로)을 입력하세요: ");
	scanf_s("%d", &time);
	Time(time);
}


//
//float Meter(float cm) //cm를 m로 변환
//{
//	return cm / 100;
//}
//
//int main()
//{
//	float cm;
//
//	printf("키(cm단위로) 입력하세요: ");
//	scanf_s("%f", &cm);
//
//	printf("%.3fm입니다.\n", Meter(cm));
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
//	printf("안녕하세요,\n");
//	printf("반갑습니다.\n");
//	printf("오늘은 4월 입니다.\n");
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
//	printf("받은 돈은 %d 원 입니다.\n", money);
//	int cost = 500; //비용
//	printf("음료의 가격은 %d 원 입니다.\n", cost);
//	int result;
//
//	if (money >= cost)
//	{
//		result = money - cost;
//		printf("음료 드쇼, 잔돈은 %d\n", result);
//	}
//	else
//	{
//		result = money;
//		printf("돈이 부족함, 잔돈은 %d\n", result);
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
	printf("자판기에 넣을 금액을 입력 하세요: ");

	scanf_s("%d", &money);

	printf("받은 잔돈은: %d\n", Japangi(money));*/

//}
//
//int main()
//{
//	printf("%f", Pi());
//}