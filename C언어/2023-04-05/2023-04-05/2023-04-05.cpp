#include<stdio.h>
#include<stdlib.h>
#include<time.h>
//���� �Է¹޾Ƽ� ��쿡 ���� ������������ ����Ѵ�.
void NumToTextPrint(int n)
{
	if (n == 1)
	{
		printf("����");
	}
	else if (n == 2)
	{
		printf("����");
	}
	else
	{
		printf("��");
	}
}
int main(void)
{
	int yourSelection;//����� ���������� ���� ����
	int pcSelection;//pc�� ���������� ���� ����

	int result[3][3] =
	{
		{0,1,-1},
		{-1,0,1},
		{1,-1,0}
	};
	while (1)
	{
		printf("����������!!\n");
		printf("����(0),����(1),��(2) (0~2)�߿� �Է�: ");
		scanf_s("%d", &yourSelection);

		printf("����� �� ������������: ");
		NumToTextPrint(yourSelection);
		srand(time(NULL));

		pcSelection = rand() % 3;//���������� ���� 0~2�� �з�
		printf("\n��ǻ�Ͱ� �� ������������: ");
		NumToTextPrint(pcSelection);
		printf("\n");

		if (result[pcSelection][yourSelection] == 0)
		{
			printf("���º�\n");
		}
		else if (result[pcSelection][yourSelection] == 1)
		{
			printf("�̰���ϴ�.\n");
		}
		else
		{
			printf("�����ϴ�.\n");
		}
	}
}