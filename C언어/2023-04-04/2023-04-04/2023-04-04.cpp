#include<stdio.h> //입출력
#include<stdlib.h> //랜덤
#include<time.h> //시드

int main(void) //가위바위보 함수
{
	srand(time(NULL));
	int user;
	int sicssors = 1;
	int rock = 2;
	int paper = 3;
	int computer = rand() % 3 + 1; //1~3으로 나타내기

	printf("당신의 선택은 (가위:1, 바위:2, 보:3) : ");
	scanf_s("%d", &user);


	printf("당신의 선택은 "); //유저 값 출력
	switch (user)
	{
	case 1:
		printf("가위 \n");
		break;
	case 2:
		printf("바위 \n");
		break;
	case 3:
		printf("보 \n");
		break;
	}

	printf("컴퓨터의 선택은 "); //컴 랜덤값 출력
	switch (computer)
	{
	case 1:
		printf("가위 \n");
		break;
	case 2:
		printf("바위 \n");
		break;
	case 3:
		printf("보 \n");
		break;
	}
	
	if (user == computer) //결과값 출력
	{
		printf("비겼습니다.\n");
	}
	else if ((user == 1 && computer == 3) || (user == 2 && computer == 1) || (user == 3 && computer == 2))
	{
		printf("당신이 이겼습니다.\n");
	}
	else
	{
		printf("당신이 졌습니다.\n");
	}

}





//int main(void)
//{
//	srand(time(NULL));
//	for (int i = 0; i < 10; i++)
//	{
//		printf("%d\n", rand());
//	}
//
//}


//const int length = 5;
//int arr[length];
//
//int GetArrData(int index)
//{//인덱스 범위를 벗어났을때
//	if (index<0 || index>=length)
//	{
//		printf("범위를 벗어남");
//		return -1;
//	}
//	return arr[index];
//}
//int main(void)
//{
//	printf("%d", GetArrData(1));
//}