#include<stdio.h>

int main(void)
{
	int count; //���� ����
	int sum = 0; //�հ�

	printf("�Է��� ���� ����: ");
	scanf_s("%d", &count);

	for (int i = 1; i <= count; i++)
	{
		int num; //�Է��� ����
		printf("%d��° ���ڸ� �Է��ϼ���: ", i);
		scanf_s("%d", &num);
		sum = sum + num;
	}
	printf("�հ�: %d\n", sum);
	float avg = (float)sum / count; //���
	printf("���: %0.1f\n", avg);



	//int i = 10;
	//float f = i;
	//i = f;
	//printf("%d\n", i);
	//printf("%f\n", (float)i);
	//printf("%f\n", i);



	//for (int i = 0; i < 5; i+= 2)
	//{
	//	printf("%d ", i);
	//}



	//int num = 5;

	//num *= 1+5;

	//printf("%d\n", num);



	//int count;
	//int next;
	//int left=1;
	//int right = 1;

	//printf("�Ǻ���ġ ������ �Է�: ");
	//scanf_s("%d", &count);

	//for (int i = 0; i < count; i++)
	//{
	//	printf("%d ", left);
	//	next = left + right;
	//	left = right;
	//	right = next;
	//}
}