#include<stdio.h>

int main(void)
{

	float kor;
	float eng;
	float math;

	printf("국어점수를 입력하세요: ");
	scanf_s("%f", &kor);
	printf("영어점수를 입력하세요: ");
	scanf_s("%f", &eng);
	printf("수학점수를 입력하세요: ");
	scanf_s("%f", &math);

	int avg = (kor + eng + math) / 3;
	printf("평균 점수 : %d ", avg);


	switch (avg / 10)
	{
	case 10:
	case 9:
		printf("\n성적: A");
		break;
	case 8:
		printf("\n성적: B");
		break;
	case 7:
		printf("\n성적: C");
		break;
	case 6:
		printf("\n성적: D");
		break;
	default:
		printf("\n성적: F");
		break;
	}







	//int num;

	//printf("1 ~ 10 사이의 숫자를 입력하세요: ");
	//scanf_s("%d", &num);

	//switch (num%2)
	//{
	//case 0:
	//	printf("짝수");
	//	break;

	//default:
	//	printf("홀수");
	//	break;

	//}


	//int num = 7;

	//switch (num)
	//{
	//case 0:
	//	printf("num값은 0");
	//	break;

	//case 1:
	//	printf("num값은 1");
	//	break;

	//case 2:
	//	printf("num값은 2");
	//	break;

	//default:
	//	break;
	//}



	//float kor;
	//float eng;
	//float math;

	//printf("국어점수를 입력하세요: ");
	//scanf_s("%f", &kor);
	//printf("영어점수를 입력하세요: ");
	//scanf_s("%f", &eng);
	//printf("수학점수를 입력하세요: ");
	//scanf_s("%f", &math);

	//float avg = (kor + eng + math) / 3;
	//printf("%0.0f", avg);
	//if (avg >= 90)
	//	printf("\n당신의 등급은: A");
	//else if (avg >= 80)
	//{
	//	printf("\n당신의 등급은: B");
	//}
	//else if (avg >= 70)
	//{
	//	printf("\n당신의 등급은: C");
	//}
	//else if (avg >= 60)
	//{
	//	printf("\n당신의 등급은: D");
	//}
	//else
	//{
	//	printf("\n당신의 등급은: F");
	//}



	//int money;

	//printf("금액을 입력하세요: ");
	//scanf_s("%d", &money);

	//if (money >= 10000)
	//{
	//	printf("국밥");
	//}
	//else if (money >= 5000)
	//{
	//	printf("도시락");
	//}
	//else
	//{
	//	printf("삼각김밥");
	//}



	//float cm;
	//int age;

	//printf("키를 입력하세요: ");
	//scanf_s("%f", &cm);
	//printf("나이를 입력하세요: ");
	//scanf_s("%d", &age);

	//if (cm >=130 && age > 6)
	//{
	//	printf("탑승가능합니다.");
	//}
	//else
	//{
	//	printf("탑승 불가능합니다.");
	//}
}