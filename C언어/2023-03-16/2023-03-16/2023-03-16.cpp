#include<stdio.h>

int main(void)
{
	int time;

	printf("'시,분,초'로 환산하고 싶은 초를 쓰십시오.: ");
	scanf_s("%d", &time);

	int sec = time % 60; //seconds
	int min = time / 60 % 60; //minutes
	int hour = time / 60 / 60; //hours

	printf("%d시 ", hour);
	printf("%d분 ", min);
	printf("%d초 ", sec);



/*
	//복숭아의 개수
	int peach;

	printf("복숭아의 개수를 입력하세요: ");
	scanf_s("%d", &peach);
	
	//꽉찬 바구니의 수
	int box = peach /8;
	//남은 복숭아의 수
	int remain = peach % 8;

	printf("\n복숭아의 개수는 : %d", peach);
	printf("\n꽉찬 바구니의 개수는 : %d", box);
	printf("\n남은 복숭아의 개수는 : %d", remain);
*/

	/*
	char c;

	scanf_s("%c", &c);
	printf("입력한 문자 %c", c);
	*/

/*
	int num1;
	int num2;

	printf("첫번째 정수를 입력 하세요: ");
	scanf_s("%d", &num1);
	printf("두번째 정수를 입력 하세요: ");
	scanf_s("%d", &num2);

	int sum = num1 + num2;


	printf("합계는 %d 입니다.", sum);
*/

/*
	int age;

	printf("나이를 입력하세요 :");
	scanf_s("\n%d", &age);
	printf("입력한 나이는 %d 살 입니다.", age);


	int num;

	scanf_s("%d", &num);
	printf("%d", num);

*/

}