#include<stdio.h>

int main(void)
{


	/*char arr[3][3];

	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			if ((i + j) % 2 == 1)
			{
				arr[i][j] = 'O';
			}
			else
			{
				arr[i][j] = 'X';
			}
		}
	}
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			printf("%c ", arr[i][j]);
		}
		printf("\n");
	}*/
	


	/*
	int arr[3][3];

	printf("%p\n", arr);
	printf("%p\n", &arr[0][0]);
	printf("----------------\n");
	printf("%p\n", &arr[0][1]);
	printf("----------------\n");
	printf("%p\n", &arr[0][2]);
	printf("%p\n", &arr[1][-1]);
	printf("----------------\n");
	printf("%p\n", &arr[0][3]);
	printf("%p\n", &arr[1][0]);
	printf("----------------\n");
	*/



	/*
	const int x = 15;
	const int y = 30;


	int arr[y][x];
	int num = 1; //�����ϴ� ���� ��


	for (int i = 0; i < y; i++) //���� �� �迭 �ʱ�ȭ ����Ʈ
	{
		for (int j = 0; j < x; j++)
		{
			arr[i][j] = num;
			num += 1;
		}
	}


	int temp = arr[y-1][x-1]; //������ �迭 ����

	for (int i = y-1; i >= 0; i--) //��ĭ�� �б�
	{
		for (int j = x-1; j >= 0; j--)
		{
			arr[i][j] = arr[i][j - 1];
		}
	}
	arr[0][0] = temp; //�� �� �迭�� ������ �� �ֱ�

	for (int i = 0; i < y; i++) //���
	{
		for (int j = 0; j < x; j++)
		{
			printf("%3d ", arr[i][j]);
		}
		printf("\n");
	}*/
}