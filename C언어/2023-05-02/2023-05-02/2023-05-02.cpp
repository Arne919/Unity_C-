#include<stdio.h>

int main(void)
{
	////11. �ݺ�Ƚ�� �Է�
	////	�Է¹��� �ݺ� Ƚ����ŭ ���� �Է¹ޱ�
	////	�� ���ڵ��� �հ�� ��� �Ҽ��� 2��° �ڸ����� ���

	//int count;
	//int sum = 0;
	//printf("�Է��� ���� ����: ");
	//scanf_s("%d", &count);

	//for (int i = 1; i <= count; i++)
	//{
	//	int num; //�Է��� ����
	//	printf("%d��° ���ڸ� �Է��ϼ���: ",i);
	//	scanf_s("%d", &sum);
	//	sum = sum + sum;

	//}
	//printf("�հ�: %d\n", sum);
	//float avg = (float)sum / count;//���
	//printf("���: %.1f\n", avg);



	////12. 12345~13256 ������ 7�� ��� ���

	//int start = 12345;
	//int end = 13256;
	//int div = 7;
	//while (start % div != 0)
	//{
	//	start++;
	//}
	//for (int i = start; i <= end; i += div)
	//{
	//	printf("\n%d", i);
	//}



	//13. 12������ 7�� ����� 6�� ����� ���

	//int start = 12345;
	//int end = 13256;
	//int div1 = 7;
	//int div2 = 6;

	//for (int i = start; i <= end; i++)
	//{
	//	if (i % div1 == 0 || i % div2 == 0)
	//	{
	//		printf("%d\n", i);
	//	}
	//	else if (i % div1 == 0 && i % div2 == 0)
	//	{
	//		printf("%d\n", i);
	//	}
	//}

	int arr[5] = { 1,2,3,4,5 };

	for (int i = 0; i < 5; i++) //���
	{
		printf("%d ", arr[i]);
	}



}