#include<stdio.h>

int main(void)
{

	int f;
	int f1 = 1;//first number
	int f2 = 1;//second number

	printf("�Ǻ���ġ ���� ����: ");
	scanf_s("%d", &f);

	if (f == 1)
		printf("%d ", f1);
	else if (f <= 0)
		printf("������ �� �����ϴ�.");
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



	//int f;
	//int f1 = 1;//first number
	//int f2 = 1;//second number

	//printf("�Ǻ���ġ ���� ����: ");
	//scanf_s("%d", &f);


	//if (f == 1)
	//	printf("%d ", f1);
	//else if (f <= 0)
	//	printf("������ �� �����ϴ�.");
	//else
	//{
	//	printf("%d %d ", f1, f2);
	//int i = 0;
	//while (i < f-2)
	//{
	//	int sum = f1 + f2;
	//	f1 = f2;
	//	f2 = sum;

	//	printf("%d ", sum);
	//	i++;
	//}
	//}



	//while (true)
	//{
	//	printf("�ȳ�\n");
	//	break;
	//}
	//printf("Ż��~");



	//int floor;

	//printf("������ �Է��ϼ���: ");
	//scanf_s("%d", &floor);

	//for (int i = 1; i <= floor; i++)
	//{
	//	for (int j = floor; j > i; j--)
	//	{
	//		printf(" ");
	//	}
	//	for (int k = 1; k <= i; k++)
	//	{
	//		printf("*");
	//	}
	//	printf("\n");
	//}
}