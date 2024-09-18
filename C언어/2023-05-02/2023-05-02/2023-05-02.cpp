#include<stdio.h>

int main(void)
{
	////11. 반복횟수 입력
	////	입력받은 반복 횟수만큼 숫자 입력받기
	////	그 숫자들의 합계와 평균 소수점 2번째 자리까지 출력

	//int count;
	//int sum = 0;
	//printf("입력할 숫자 개수: ");
	//scanf_s("%d", &count);

	//for (int i = 1; i <= count; i++)
	//{
	//	int num; //입력할 숫자
	//	printf("%d번째 숫자를 입력하세요: ",i);
	//	scanf_s("%d", &sum);
	//	sum = sum + sum;

	//}
	//printf("합계: %d\n", sum);
	//float avg = (float)sum / count;//평균
	//printf("평균: %.1f\n", avg);



	////12. 12345~13256 사이의 7의 배수 출력

	//int start = 12345;
	//int end = 13256;
	//int div = 7;
	//while (start % div != 0)
	//{
	//	start++;
	//}
	//for (int i = start; i <= end; i += div)
	//{
	//	printf("\n%d", i);
	//}



	//13. 12번에서 7의 배수와 6의 배수를 출력

	//int start = 12345;
	//int end = 13256;
	//int div1 = 7;
	//int div2 = 6;

	//for (int i = start; i <= end; i++)
	//{
	//	if (i % div1 == 0 || i % div2 == 0)
	//	{
	//		printf("%d\n", i);
	//	}
	//	else if (i % div1 == 0 && i % div2 == 0)
	//	{
	//		printf("%d\n", i);
	//	}
	//}

	int arr[5] = { 1,2,3,4,5 };

	for (int i = 0; i < 5; i++) //출력
	{
		printf("%d ", arr[i]);
	}



}