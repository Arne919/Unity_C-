#include<stdio.h> //�����
#include<stdlib.h> //����
#include<time.h> //�õ�

int main(void) //���������� �Լ�
{
	srand(time(NULL));
	int user;
	int sicssors = 1;
	int rock = 2;
	int paper = 3;
	int computer = rand() % 3 + 1; //1~3���� ��Ÿ����

	printf("����� ������ (����:1, ����:2, ��:3) : ");
	scanf_s("%d", &user);


	printf("����� ������ "); //���� �� ���
	switch (user)
	{
	case 1:
		printf("���� \n");
		break;
	case 2:
		printf("���� \n");
		break;
	case 3:
		printf("�� \n");
		break;
	}

	printf("��ǻ���� ������ "); //�� ������ ���
	switch (computer)
	{
	case 1:
		printf("���� \n");
		break;
	case 2:
		printf("���� \n");
		break;
	case 3:
		printf("�� \n");
		break;
	}
	
	if (user == computer) //����� ���
	{
		printf("�����ϴ�.\n");
	}
	else if ((user == 1 && computer == 3) || (user == 2 && computer == 1) || (user == 3 && computer == 2))
	{
		printf("����� �̰���ϴ�.\n");
	}
	else
	{
		printf("����� �����ϴ�.\n");
	}

}





//int main(void)
//{
//	srand(time(NULL));
//	for (int i = 0; i < 10; i++)
//	{
//		printf("%d\n", rand());
//	}
//
//}


//const int length = 5;
//int arr[length];
//
//int GetArrData(int index)
//{//�ε��� ������ �������
//	if (index<0 || index>=length)
//	{
//		printf("������ ���");
//		return -1;
//	}
//	return arr[index];
//}
//int main(void)
//{
//	printf("%d", GetArrData(1));
//}