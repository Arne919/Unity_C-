#include<stdio.h>

int main(void)
{

	int arr[200];


	for (int i = 0; i < 200; i++)
	{
		arr[i] = (i + 1) * 3;
	}
	for (int i = 0; i < 200; i++)
	{
		printf("%d ", arr[i]);
	}
	
	

	//int arr[5] = { 10,20,30,40,50 };
	//for (int i = 0; i < 5; i++)
	//{
	//	printf("%d ", arr[i]);
	//}



	//int d1, d2, d3;
	//int money;

	//printf("�ֻ��� ���� 3���� �Է����ּ���.\n");

	//printf("1��° �ֻ���: ");
	//scanf_s("%d", &d1);
	//printf("2��° �ֻ���: ");
	//scanf_s("%d", &d2);
	//printf("3��° �ֻ���: ");
	//scanf_s("%d", &d3);

	//if (d1 == d2 && d1 == d3)//������ 3��
	//	money = 10000 + d1 * 1000;
	//else if (d1 == d2 || d1 == d3)//������ 2��(1,2/1,3)
	//	money = 1000 + d1 * 100;
	//else if (d2 == d3)//������ 2��(2,3)
	//	money = 1000 + d2 * 100;
	//else//�� �ٸ�
	//{
	//	int max = d1;
	//	if (max < d2)
	//	{
	//		max = d2;
	//	}
	//	if (max < d3)
	//	{
	//		max = d3;
	//	}
	//	money = max * 100;
	//}
	//printf("���: %d", money);
}