#include<stdio.h>

int main(void)
{
	int time;

	printf("'��,��,��'�� ȯ���ϰ� ���� �ʸ� ���ʽÿ�.: ");
	scanf_s("%d", &time);

	int sec = time % 60; //seconds
	int min = time / 60 % 60; //minutes
	int hour = time / 60 / 60; //hours

	printf("%d�� ", hour);
	printf("%d�� ", min);
	printf("%d�� ", sec);



/*
	//�������� ����
	int peach;

	printf("�������� ������ �Է��ϼ���: ");
	scanf_s("%d", &peach);
	
	//���� �ٱ����� ��
	int box = peach /8;
	//���� �������� ��
	int remain = peach % 8;

	printf("\n�������� ������ : %d", peach);
	printf("\n���� �ٱ����� ������ : %d", box);
	printf("\n���� �������� ������ : %d", remain);
*/

	/*
	char c;

	scanf_s("%c", &c);
	printf("�Է��� ���� %c", c);
	*/

/*
	int num1;
	int num2;

	printf("ù��° ������ �Է� �ϼ���: ");
	scanf_s("%d", &num1);
	printf("�ι�° ������ �Է� �ϼ���: ");
	scanf_s("%d", &num2);

	int sum = num1 + num2;


	printf("�հ�� %d �Դϴ�.", sum);
*/

/*
	int age;

	printf("���̸� �Է��ϼ��� :");
	scanf_s("\n%d", &age);
	printf("�Է��� ���̴� %d �� �Դϴ�.", age);


	int num;

	scanf_s("%d", &num);
	printf("%d", num);

*/

}