#include<stdio.h>

int main(void)
{

	int age;

	printf("나이를 입력하세요: ");
	scanf_s("%d", &age);

	if (age > 19)
	{
		printf("성인입니다.");
	}
	else
	{
		printf("성인이 아닙니다.");
	}


	//if (true != false)
	//{
	//	printf("조건이 참이다.");
	//}
	//else
	//{
	//	printf("조건이 거짓이다.");
	//}

}