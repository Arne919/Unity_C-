#include<stdio.h>

int main(void)
{
	int count; //숫자 개수
	int sum = 0; //합계

	printf("입력할 숫자 개수: ");
	scanf_s("%d", &count);

	for (int i = 1; i <= count; i++)
	{
		int num; //입력할 숫자
		printf("%d번째 숫자를 입력하세요: ", i);
		scanf_s("%d", &num);
		sum = sum + num;
	}
	printf("합계: %d\n", sum);
	float avg = (float)sum / count; //평균
	printf("평균: %0.1f\n", avg);



	//int i = 10;
	//float f = i;
	//i = f;
	//printf("%d\n", i);
	//printf("%f\n", (float)i);
	//printf("%f\n", i);



	//for (int i = 0; i < 5; i+= 2)
	//{
	//	printf("%d ", i);
	//}



	//int num = 5;

	//num *= 1+5;

	//printf("%d\n", num);



	//int count;
	//int next;
	//int left=1;
	//int right = 1;

	//printf("피보나치 개수를 입력: ");
	//scanf_s("%d", &count);

	//for (int i = 0; i < count; i++)
	//{
	//	printf("%d ", left);
	//	next = left + right;
	//	left = right;
	//	right = next;
	//}
}