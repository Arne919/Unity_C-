#include<stdio.h>

int main(void)
{
	int d1, d2, d3;

	printf("�ֻ��� ���� 3���� �Է����ּ���.\n");

	printf("1��° �ֻ���: ");
	scanf_s("%d", &d1);
	printf("2��° �ֻ���: ");
	scanf_s("%d", &d2);
	printf("3��° �ֻ���: ");
	scanf_s("%d", &d3);

	if (d1 == d2 && d1 == d3)//������ 3��
		printf("���: %d", 10000 + d1 * 1000);
	else if (d1 == d2 || d1 == d3)//������ 2��(1,2/1,3)
		printf("���: %d", 1000 + d1 * 100);
	else if (d2 == d3)//������ 2��(2,3)
		printf("���: %d", 1000 + d2 * 100);
	else if (d1 > d2 || d1 > d3)
		printf("���: %d", d1 * 100);
	else if (d2 > d3)
		printf("���: %d", d2 * 100);
	else
		printf("���: %d", d3 * 100);




	//int start = 2458;
	//int end = 2622;
	//int div = 6;
	//int count = 0;

	//while (start % div != 0)
	//{
	//	count++;
	//	start++;
	//}
	//for (int i = start; i <= end; i += 6)
	//{
	//	count++;
	//	printf("%d\n", i);
	//}
	//printf("\n\n%d", count);



	//for (int i = 2458; i <= 2622; i++)
	//{
	//	count++;
	//	if (i % 6 == 0)
	//	{
	//		printf("%d\n", i);
	//		i += 5;
	//	}
	//}
}
