#include<stdio.h>

int main(void)
{
	int dan, num;

	for (int dan = 2; dan <= 9; dan++)
	{
		for (int num = 1; num <= 9; num++)
		{
			printf("%d * %d = %d\n", dan, num, dan * num);
		}
		printf("\n");
	}

	//----------------------------------

	//int smalldan, bigdan, small, big;

	//printf("������ �� �Է�: ");
	//scanf_s("%d", &smalldan);
	//printf("���� �� �Է�: ");
	//scanf_s("%d", &bigdan);
	//printf("���� ������ ���� �Է�: ");
	//scanf_s("%d", &small);
	//printf("���� ���� ���� �Է�: ");
	//scanf_s("%d", &big);

	//if (smalldan > bigdan)
	//{
	//	int temp = smalldan;
	//	smalldan = bigdan;
	//	bigdan = temp;
	//}
	//if (small > big)
	//{
	//		int temp = small;
	//		small = big;
	//		big = temp;
	//}
	//for (int i= smalldan; i<= bigdan; i++)
	//{
	//	for (int j = small; j <= big; j++)
	//	{
	//	printf("%d * %d = %d\n", i, j, i * j);
	//	}
	//}

	//----------------------------------

	//int num = 0;

	//for (int i = 0; i < 3; i++)
	//{
	//	for (int i = 0; i < 2; i++)
	//	{
	//		printf("%d\n",num); 
	//		num++;
	//	}
	//}

	//----------------------------------

	//for (int i = 0; i < 3; i++)
	//{
	//	for (int i = 0; i < 2; i++)
	//	{
	//		printf("�ȳ�\n");
	//	}
	//}

	//----------------------------------

	int dan, small, big;

	printf("���� �Է��ϼ���: ");
	scanf_s("%d", &dan);
	printf("ù��° ���� �Է�: ");
	scanf_s("%d", &small);
	printf("�ι�° ���� �Է�: ");
	scanf_s("%d", &big);

	if (small>big)
	{
		int temp = small;
		small = big;
		big = temp;
	}
		for (int i = small; i <= big; i++)
		{
			printf("%d * %d = %d\n", dan, i, dan * i);
		}

	//----------------------------------

	//int dan, n1, n2, small, big;

	//printf("���� �Է��ϼ���: ");
	//scanf_s("%d", &dan);
	//printf("ù��° ���� �Է�: ");
	//scanf_s("%d", &n1);
	//printf("�ι�° ���� �Է�: ");
	//scanf_s("%d", &n2);

	//if (n1 > n2)
	//{
	//	big = n1;
	//	small = n2;
	//}
	//else
	//{
	//	small = n1;
	//	big = n2;
	//}
	//	for (int i = small; i <= big; i++)
	//	{
	//		printf("%d * %d = %d\n", dan, i, dan * i);
	//	}

	//----------------------------------

	//int dan, n1, n2;

	//printf("���� �Է��ϼ���: ");
	//scanf_s("%d", &dan);
	//printf("ù��° ���� �Է�: ");
	//scanf_s("%d", &n1);
	//printf("�ι�° ���� �Է�: ");
	//scanf_s("%d", &n2);

	//if (n1 > n2)
	//{
	//	for (int i = n2; i <= n1; i++)
	//	{
	//		printf("%d * %d = %d\n", dan,i, dan*i);
	//	}
	//}
	//else
	//{
	//	for (int i = n1; i <= n2; i++)
	//	{
	//		printf("%d * %d = %d\n", dan, i, dan*i);
	//	}
	//}
}