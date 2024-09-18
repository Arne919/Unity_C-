#include<stdio.h>

int main(void)
{
	int arr[10] = { 15,27,33,10,99,67,55,285,128,444 };


	int temp = arr[9]; //arr[9]값 temp에 저장

	for (int i = 9; i > 0; i--) //오른쪽으로 밀기
	{
		arr[i] = arr[i - 1];
	}
	arr[0] = temp; //arr[0]값 temp에서 가져오기
	for (int i = 0; i < 10; i++) //출력
	{
		printf("%d ", arr[i]);
	}



	//반복문 사용
	//길이가 3인 배열
	//숫자 3개 입력 (배열에)
	//배열의 합계와 평균을 출력하세요.

	//const int length = 3;
	//int arr[length];//길이3
	//int sum = 0;
	//for (int i = 0; i < length; i++)
	//{ 
	//	scanf_s("%d", &arr[i]);//입력
	//	sum += arr[i];
	//}
	//float avg = (float)sum / length;
	//printf("합계: %d\n평균 :%.1f", sum, avg);



	//int arr[10];//길이10

	//for (int i = 0; i < 10; i++)
	//{
	//	scanf_s("%d", &arr[i]);//입력
	//}
	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n", arr[i]);//출력
	//}



	//int arr[3];

	//scanf_s("%d", &arr[0]);
	//scanf_s("%d", &arr[1]);
	//scanf_s("%d", &arr[2]);

	//printf("%d\n", arr[0]);
	//printf("%d\n", arr[1]);
	//printf("%d\n", arr[2]);
}