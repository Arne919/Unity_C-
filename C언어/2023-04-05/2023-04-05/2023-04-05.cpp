#include<stdio.h>
#include<stdlib.h>
#include<time.h>
//숫자 입력받아서 경우에 따라 가위바위보를 출력한다.
void NumToTextPrint(int n)
{
	if (n == 1)
	{
		printf("가위");
	}
	else if (n == 2)
	{
		printf("바위");
	}
	else
	{
		printf("보");
	}
}
int main(void)
{
	int yourSelection;//사람의 가위바위보 선택 변수
	int pcSelection;//pc의 가위바위보 선택 변수

	int result[3][3] =
	{
		{0,1,-1},
		{-1,0,1},
		{1,-1,0}
	};
	while (1)
	{
		printf("가위바위보!!\n");
		printf("가위(0),바위(1),보(2) (0~2)중에 입력: ");
		scanf_s("%d", &yourSelection);

		printf("사람이 낸 가위바위보는: ");
		NumToTextPrint(yourSelection);
		srand(time(NULL));

		pcSelection = rand() % 3;//가위바위보 값을 0~2로 분류
		printf("\n컴퓨터가 낸 가위바위보는: ");
		NumToTextPrint(pcSelection);
		printf("\n");

		if (result[pcSelection][yourSelection] == 0)
		{
			printf("무승부\n");
		}
		else if (result[pcSelection][yourSelection] == 1)
		{
			printf("이겼습니다.\n");
		}
		else
		{
			printf("졌습니다.\n");
		}
	}
}