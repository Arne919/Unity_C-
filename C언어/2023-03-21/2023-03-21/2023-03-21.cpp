#include<stdio.h>

int main(void)
{
	int num, start, end;

	printf("���ϴ� �ܼ��� �Է��ϼ���: ");
	scanf_s("%d", &num);
	printf("%d�ܿ� ���ϱ⸦ ������ ���ڸ� �Է��ϼ���: ", num);
	scanf_s("%d", &start);
	printf("%d�ܿ� ���ϱ⸦ ������ ���ڸ� �Է��ϼ���: ", num);
	scanf_s("%d", &end);

	for (int i = start; i <= end; i++)
	{
		printf("%d * %d = %d\n", num, i, num * i);
	}



	//int n;

	//printf("���ϴ� �ܼ��� �Է��ϼ���: ");
	//scanf_s("%d", &n);

	//for (int i = 1; i < 10; i++)
	//{
	//printf("%d * %d = %d\n", n,i,n*i);
	//}



	//for (int i = 1; i < 10; i++)
	//{
	//printf("3 * %d = %d\n", i,3*i);
	//}



	//for (int i = 1; i < 46; i++)
	//{
	//	if (i % 5 == 0)
	//	{
	//		printf("5 * %d = %d\n", i / 5, i);
	//	}
	//}


	//for (int i = 1; i < 10; i++)
	//{
	//	printf("5 * %d = %d\n", i,5*i);
	//}



	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n", i * 2);
	//}



	//for (int i = 0; i < 10; i++)
	//{
	//	printf("%d\n", i);
	//}



	//for (int i = 0; i < 3; i++)
	//{
	//	printf("%d\n", i);
	//}



	//for (int i = 0; i < 3; i++)
	//{
	//	printf("�ȳ�\n");
	//}



	//
	//enum state
	//{
	//	nomal,
	//	sturn,
	//	stop,
	//	air
	//};

	//int state = 0;

	//switch (state)
	//{
	//case nomal:
	//	printf("�븻");
	//	break;
	//case sturn:
	//	printf("����");
	//	break;
	//case stop:
	//	printf("�ӹ�");
	//	break;
	//case air:
	//	printf("���");
	//	break;
	//}

	//if (state == 0)
	//{
	//	printf("�븻");
	//}
	//else if (state == 1)
	//{
	//	//	printf("����");
	//}
	//else if (state == 2)
	//{
	//	//	printf("�ӹ�");
	//}
	//else if (state == 3)
	//{
	//	//	printf("���");
	//}



	//X % 2 == 0 -> ¦��
	//X % 2 == 1 -> Ȧ��

	//int num;

	//scanf_s("%d", &num);

	//if (num % 2 == 0)
	//{
	//	printf("¦��");
	//}
	//else
	//{
	//	printf("Ȧ��");
	//}


	//switch (num % 2)
	//{
	//case 0:
	//	printf("¦��");
	//	break;
	//default:
	//	printf("Ȧ��");
	//	break;
	//}
}