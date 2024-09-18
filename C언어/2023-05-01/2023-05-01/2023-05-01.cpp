//#include<stdio.h>
//
//int main(void)
//{
//	//1. 별로 삼각형 만들기
//	//	층 입력 받아서 층만큼 출력하기
//	int floor;
//	printf("층수? ");
//	scanf_s("%d", &floor);
//
//	for (int i = 1; i <= floor; i++)
//	{
//		for (int j = 1; j <= i; j++)
//		{
//			printf("*");
//		}
//		printf("\n");
//	}
//
//	//2. 역삼각형 피라미드
//	//	층 입력 받아서 층만큼 출력하기
//	int floor;
//	printf("층수? ");
//	scanf_s("%d", &floor);
//
//	for (int i = floor; i > 0; i--)
//	{
//		for (int j = 0; j < i; j++)
//		{
//			printf("*");
//		}
//		printf("\n");
//	}
//
//}

//#include<stdio.h>
//
//int main(void)
//{
//	//3. 국영수 점수 입력받기
//	//	점수의 합계와 평균 출력하기
//	int kor, eng, math;
//
//	printf("국어점수를 입력하세요: ");
//	scanf_s("%d", &kor);
//	printf("영어점수를 입력하세요: ");
//	scanf_s("%d", &eng);
//	printf("수학점수를 입력하세요: ");
//	scanf_s("%d", &math);
//
//	int sum = kor + eng + math;
//	float avg = sum / 3;
//	printf("합계 점수 : %d\n", sum);
//	printf("평균 점수 : %f\n", avg);
//}

//#include<stdio.h>
//
//int main(void)
//{
//	//4. 복숭아의 갯수를 입력
//	//	복숭아는 1바구니에 8개씩 담을수 있음
//	//	꽉찬 바구니의 수, 남은 복숭아의 수 출력
//	int peach;
//
//	printf("복숭아의 개수를 입력하세요: ");
//	scanf_s("%d", &peach);
//
//	//꽉찬 바구니의 수
//	int box = peach / 8;
//	//남은 복숭아의 수
//	int remain = peach % 8;
//
//	printf("복숭아의 개수는: %d\n", peach);
//	printf("꽉찬 바구니의 개수는: %d\n", box);
//	printf("남은 복숭아의 개수는: %d\n", remain);
//}

//#include<stdio.h>
//
//int main(void)
//{
//	//5. 시간초 입력받기
//	//	시 분 초 형태로 출력하기
//	int time;
//
//	printf("시 분 초로 환산하고 싶은 초를 쓰십시오: ");
//	scanf_s("%d", &time);
//
//	int sec = time % 60;//seconds
//	int min = time / 60 % 60;//minutes
//	int hour = time / 60 / 60;//hours
//
//	printf("%d시 %d분 %d초 ", hour, min, sec);
//}

//#include<stdio.h>
//
//int main(void)
//{
//	//6. 국영수 점수 입력받기
//	//	입력받은 점수의 평균에 따라
//	//	90점이상 A / 80점이상 B / 70점이상 C / 60점이상 D
//	//	그게 아니라면 F
//	//	IF문으로 만들기
//		
//	float kor;
//	float eng;
//	float math;
//
//	printf("국어점수를 입력하세요: ");
//	scanf_s("%f", &kor);
//	printf("영어점수를 입력하세요: ");
//	scanf_s("%f", &eng);
//	printf("수학점수를 입력하세요: ");
//	scanf_s("%f", &math);
//
//	float avg = (kor + eng + math) / 3;
//	printf("%0.0f", avg);
//	if (avg >= 90)
//		printf("\n당신의 등급은: A");
//	else if (avg >= 80)
//	{
//		printf("\n당신의 등급은: B");
//	}
//	else if (avg >= 70)
//	{
//		printf("\n당신의 등급은: C");
//	}
//	else if (avg >= 60)
//	{
//		printf("\n당신의 등급은: D");
//	}
//	else
//	{
//		printf("\n당신의 등급은: F");
//	}
//}

//#include<stdio.h>
//
//int main(void)
//{
//	//7. 6번을 switch로 만들기
//
//	float kor;
//	float eng;
//	float math;
//
//	printf("국어점수를 입력하세요: ");
//	scanf_s("%f", &kor);
//	printf("영어점수를 입력하세요: ");
//	scanf_s("%f", &eng);
//	printf("수학점수를 입력하세요: ");
//	scanf_s("%f", &math);
//
//	int avg = (kor + eng + math) / 3;
//	printf("평균 점수 : %d ", avg);
//
//
//	switch (avg / 10)
//	{
//	case 10:
//	case 9:
//		printf("\n성적: A");
//		break;
//	case 8:
//		printf("\n성적: B");
//		break;
//	case 7:
//		printf("\n성적: C");
//		break;
//	case 6:
//		printf("\n성적: D");
//		break;
//	default:
//		printf("\n성적: F");
//		break;
//	}
//}

//#include<stdio.h>
//
//int main(void)
//{
//	//8. 구구단 출력하기 1~9단까지
//	int dan, num;
//
//	for (int dan = 2; dan <= 9; dan++)
//	{
//		for (int num = 1; num <= 9; num++)
//		{
//			printf("%d * %d = %d\n", dan, num, dan * num);
//		}
//		printf("\n");
//	}
//}
 
//#include<stdio.h>
//
//int main(void)
//{
//	//9. 숫자 2개 입력
//	//	둘중 작은 숫자부터 큰 숫자까지에 대해
//	//	구구단 출력하기
//
//	int dan, small, big;
//
//	printf("단을 입력하세요: ");
//	scanf_s("%d", &dan);
//	printf("첫번째 숫자 입력: ");
//	scanf_s("%d", &small);
//	printf("두번째 숫자 입력: ");
//	scanf_s("%d", &big);
//
//	if (small > big)
//	{
//		int temp = small;
//		small = big;
//		big = temp;
//	}
//	for (int i = small; i <= big; i++)
//	{
//		printf("%d * %d = %d\n", dan, i, dan * i);
//	}
//}

#include<stdio.h>

int main(void)
{
	//10. 숫자를 입력
	//	입력받은 개수만큼 피보나치 수열 출력하기
	int f;
	int f1 = 1;//first number
	int f2 = 1;//second number

	printf("피보나치 수열 개수: ");
	scanf_s("%d", &f);

	if (f == 1)
		printf("%d ", f1);
	else if (f <= 0)
		printf("나열할 수 없습니다.");
	else
	{
		printf("%d %d ", f1, f2);

		for (int i = 0; i < f - 2; i++)
		{
			int sum = f1 + f2;
			f1 = f2;
			f2 = sum;

			printf("%d ", sum);
		}
	}
}