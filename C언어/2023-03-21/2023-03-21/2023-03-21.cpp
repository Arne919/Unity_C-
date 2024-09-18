#include<stdio.h>

int main(void)
{
	int num, start, end;

	printf("원하는 단수를 입력하세요: ");
	scanf_s("%d", &num);
	printf("%d단에 곱하기를 시작할 숫자를 입력하세요: ", num);
	scanf_s("%d", &start);
	printf("%d단에 곱하기를 종료할 숫자를 입력하세요: ", num);
	scanf_s("%d", &end);

	for (int i = start; i <= end; i++)
	{
		printf("%d * %d = %d\n", num, i, num * i);
	}



	//int n;

	//printf("원하는 단수를 입력하세요: ");
	//scanf_s("%d", &n);

	//for (int i = 1; i < 10; i++)
	//{
	//printf("%d * %d = %d\n", n,i,n*i);
	//}



	//for (int i = 1; i < 10; i++)
	//{
	//printf("3 * %d = %d\n", i,3*i);
	//}



	//for (int i = 1; i < 46; i++)
	//{
	//	if (i % 5 == 0)
	//	{
	//		printf("5 * %d = %d\n", i / 5, i);
	//	}
	//}


	//for (int i = 1; i < 10; i++)
	//{
	//	printf("5 * %d = %d\n", i,5*i);
	//}



	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n", i * 2);
	//}



	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n", i);
	//}



	//for (int i = 0; i < 3; i++)
	//{
	//	printf("%d\n", i);
	//}



	//for (int i = 0; i < 3; i++)
	//{
	//	printf("안녕\n");
	//}



	//
	//enum state
	//{
	//	nomal,
	//	sturn,
	//	stop,
	//	air
	//};

	//int state = 0;

	//switch (state)
	//{
	//case nomal:
	//	printf("노말");
	//	break;
	//case sturn:
	//	printf("스턴");
	//	break;
	//case stop:
	//	printf("속박");
	//	break;
	//case air:
	//	printf("에어본");
	//	break;
	//}

	//if (state == 0)
	//{
	//	printf("노말");
	//}
	//else if (state == 1)
	//{
	//	//	printf("스턴");
	//}
	//else if (state == 2)
	//{
	//	//	printf("속박");
	//}
	//else if (state == 3)
	//{
	//	//	printf("에어본");
	//}



	//X % 2 == 0 -> 짝수
	//X % 2 == 1 -> 홀수

	//int num;

	//scanf_s("%d", &num);

	//if (num % 2 == 0)
	//{
	//	printf("짝수");
	//}
	//else
	//{
	//	printf("홀수");
	//}


	//switch (num % 2)
	//{
	//case 0:
	//	printf("짝수");
	//	break;
	//default:
	//	printf("홀수");
	//	break;
	//}
}