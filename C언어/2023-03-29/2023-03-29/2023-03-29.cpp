#include<stdio.h>

int main(void)
{
	int arr[10] = { 15,27,33,10,99,67,55,285,128,444 };


	int temp = arr[9]; //arr[9]�� temp�� ����

	for (int i = 9; i > 0; i--) //���������� �б�
	{
		arr[i] = arr[i - 1];
	}
	arr[0] = temp; //arr[0]�� temp���� ��������
	for (int i = 0; i < 10; i++) //���
	{
		printf("%d ", arr[i]);
	}



	//�ݺ��� ���
	//���̰� 3�� �迭
	//���� 3�� �Է� (�迭��)
	//�迭�� �հ�� ����� ����ϼ���.

	//const int length = 3;
	//int arr[length];//����3
	//int sum = 0;
	//for (int i = 0; i < length; i++)
	//{ 
	//	scanf_s("%d", &arr[i]);//�Է�
	//	sum += arr[i];
	//}
	//float avg = (float)sum / length;
	//printf("�հ�: %d\n��� :%.1f", sum, avg);



	//int arr[10];//����10

	//for (int i = 0; i < 10; i++)
	//{
	//	scanf_s("%d", &arr[i]);//�Է�
	//}
	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n", arr[i]);//���
	//}



	//int arr[3];

	//scanf_s("%d", &arr[0]);
	//scanf_s("%d", &arr[1]);
	//scanf_s("%d", &arr[2]);

	//printf("%d\n", arr[0]);
	//printf("%d\n", arr[1]);
	//printf("%d\n", arr[2]);
}