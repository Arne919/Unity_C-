#include<stdio.h>

int main(void)
{


	const int x = 10;
	int arr[x];
	int num = 1;
	for (int i = 0; i < x; i++)

	{
		arr[i] = num;
		num += 1;
	}
	int temp = arr[0];
	for (int i = 0; i < x; i++)
	{
		arr[i] = arr[i + 1];
	}
	arr[x] = temp;
	for (int i = 0; i < x; i++)
	{
		printf("%d ", arr[i]);
	}




//	int arr[30][15];
//	int num = 1; //증가하는 수의 값
//
//
//	for (int i = 0; i < 30; i++) //변경 전 배열 초기화 리스트
//	{
//		for (int j = 0; j < 15; j++)
//		{
//			arr[i][j] = num;
//			num += 1;
//		}
//	}
//
//
//	int temp = arr[29][14]; //마지막 배열 저장
//
//	for (int i = 29; i >= 0; i--) //한칸씩 밀기
//	{
//		for (int j = 14; j >= 0; j--)
//		{
//			arr[i][j] = arr[i][j - 1];
//		}
//	}
//	arr[0][0] = temp; //맨 앞 배열에 저장한 값 넣기
//
//	for (int i = 0; i < 30; i++) //출력
//	{
//		for (int j = 0; j < 15; j++)
//		{
//			printf("%3d ", arr[i][j]);
//		}
//		printf("\n");
//	}
//}
	

	//int arr[7][5];
	//int ten = 10;

	//for (int i = 0; i < 7; i++)
	//{ //한 줄에 해야할 일
	//	for (int j = 0; j < 5; j++)
	//	{
	//		arr[i][j] = ten;
	//		ten += 10;
	//	}
	//}
	//for (int i = 0; i < 7; i++)
	//{ //한 줄에 해야할 일
	//	for (int j = 0; j < 5; j++)
	//	{
	//		printf("%3d ", arr[i][j]);
	//	}
	//	printf("\n");
	//}


	/*int arr[3][2] =
	{
		{1,2},
		{3,4},
		{5,6}
	};
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			printf("%d ", arr[i][j]);
		}
		printf("\n");
	}*/