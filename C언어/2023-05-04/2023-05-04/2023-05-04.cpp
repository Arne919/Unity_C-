#include<stdio.h>

//int main(void)
//{

	//int arr[] = {1,3,4,5,2,6,9,8,7};  // �߰��� ����� ���� (�迭�� ū �� ã��?)
	//int big = arr[0];	 
	//for (int i = 0; i < 10; i++)
	//{
	//	if (big < arr[i])
	//	{
	//		 big = arr[i];
	//	}
	//}
	// printf("%d", big);



	//2. ���ﰢ�� �Ƕ�̵�
	//	�� �Է� �޾Ƽ� ����ŭ ����ϱ�

	//int floor;
	//printf("����? ");
	//scanf_s("%d", &floor);

	//for (int i = 0; i <= floor; i++)
	//{
	//	for (int j = 0; j < i; j++)
	//	{
	//		printf(" ");
	//	}
	//	for (int k = 0; k < (floor-i)*2-1; k++)
	//	{
	//		printf("*"); // *�ϳ��� �����
	//	}
	//	printf("\n");
	//}



	//15. ���̰� 13�� �迭 ����
	//	n�� �ε����� ���� n���� �ʱ�ȭ
	//	���������� �б�

	//int arr[13];
	//int num = 0;

	//for (int i = 0; i < 13; i++) //�迭 �ʱ�ȭ
	//{
	//	arr[i] = num++;
	//}

	//int temp = arr[12]; //������ �迭 ����

	//for (int i = 12; i > 0; i--) //��ĭ�� �б�
	//{
	//	arr[i] = arr[i - 1];
	//}
	//arr[0] = temp; //�� �� �迭 ������ �� �ֱ�

	//for (int i = 0; i < 13; i++) //���
	//{
	//	printf("%d ", arr[i]);
	//}




	//16. 15���� ���� ��� �������� �а��� �Է¹ޱ�
	//	�󸶸�ŭ �а��� �Է¹ޱ�
	//	�Է¹��� ���� ���� �ٲ� �迭 ����ϱ�

	//int arr[13];
	//int num = 0;
	//int choice; //��?��?
	//int count; //�󸶸�ŭ?

	//for (int i = 0; i < 13; i++) //�迭 �ʱ�ȭ
	//{
	//	arr[i] = num++;
	//}
	//for (int i = 0; i < 13; i++) //���
	//{
	//	printf("%d ", arr[i]);
	//}

	//printf("\n �� �迭�� ��� �������� �аǰ���? (������:1, ����:2) ");
	//scanf_s("%d", &choice);

	//printf("�󸶸�ŭ �а̴ϱ�? ");
	//scanf_s("%d", &count);
	// 
	//if (choice == 1) //������
	//{
	//	for (int i = 0; i < count; i++) //�Է¹��� ��ŭ ����
	//	{
	//		int temp = arr[12]; //�迭 ����
	// 
	//		for (int j = 12; j > 0; j--) //���������� �б�
	//		{
	//			arr[j] = arr[j - 1];
	//		}
	//	arr[0] = temp; //������ �� �ֱ�
	//}
	//}
	//else if (choice == 2) //����
	//{
		//for (int i = 0; i < count; i++)
		//{
		//	int temp = arr[0]; //�迭 ����

		//	for (int j = 0; j < 12; j++) //�������� �б�
		//	{
		//		arr[j] = arr[j + 1];
		//	}
		//	arr[12] = temp;//������ �� �ֱ�
	//	}


	//}
	//for (int i = 0; i < 13; i++) //���
	//{
	//	printf("%d ", arr[i]);
	//}



	//17. 2���� �迭 �����
	//	���ΰ� 3 ���ΰ� 4�� �迭 ����
	//	1 5 9
	//	2 6 10
	//	3 7 11
	//	4 8 12
	//	�� �迭�� 16��ó�� ����� �󸶳� �а��� �Է¹޾Ƽ�
	//	�о��ֱ� ���� ����ϱ�

	//const int x = 3;
	//const int y = 4;
	//int arr[y][x];
	//int num = 1;
	//int choice;//��?��?
	//int count;//�󸶸�ŭ?

	//for (int i = 0; i < y; i++)//���η� �迭
	//{
	//	int temp = num;

	//	for (int j = 0; j < x; j++)
	//	{
	//		arr[i][j] = temp;
	//		temp += y;
	//	}
	//	num++;
	//}
	//for (int i = 0; i < y; i++)//������ �迭
	//{
	//	for (int j = 0; j < x; j++)
	//	{
	//		printf("%d ", arr[i][j]);
	//	}
	//	printf("\n");
	//}

	//printf("�� �迭�� ��� �������� �аǰ���? (������:1, ����:2) ");
	//scanf_s("%d", &choice);

	//printf("�󸶸�ŭ �а̴ϱ�? ");
	//scanf_s("%d", &count);

	//if (choice == 1) //������
	//{
	//	for (int i = 0; count > 0; count--) //�Է¹��� ��ŭ ����
	//	{
	//		int temp = arr[y - 1][x - 1]; //������ �迭 ����

	//		for (int i = y - 1; i >= 0; i--)
	//		{
	//			for (int j = x - 1; j > 0; j--)
	//			{
	//				arr[i][j] = arr[i][j - 1];
	//			}
	//			if (i > 0) //�� �����Ͽ� �б�
	//			{
	//				arr[i][0] = arr[i - 1][x - 1];
	//			}
	//		}
	//		arr[0][0] = temp; //ù �迭�� �� �ֱ�
	//	}
	//}

	//else if (choice == 2) //����
	//{
	//	for (int i = 0; count > 0; count--)//�Է¹��� ��ŭ ����
	//	{
	//		int temp = arr[0][0]; // ù �迭 ����

	//		for (int i = 0; i <= y - 1; i++)
	//		{
	//			for (int j = 0; j < x - 1; j++)
	//			{
	//				arr[i][j] = arr[i][j + 1];
	//			}
	//			if (i <= y) //�� �����Ͽ� �б�
	//			{
	//				arr[i][x - 1] = arr[i + 1][0];
	//			}
	//		}
	//		arr[y - 1][x - 1] = temp; //������ �迭�� �� �ֱ�
	//	}
	//}

	//for (int i = 0; i < y; i++) //���
	//{
	//	for (int j = 0; j < x; j++)
	//	{
	//		printf("%d ", arr[i][j]);
	//	}
	//	printf("\n");
	//}
//}



	//18. ADD �Լ� �����
	//	�Ű����� 2��
	//	�� �Ű������� ���� ���� ��ȯ �ϱ�
	//	int�� float�� 2�� �����
//int Add_int(int a, int b)
//{
//	return  a + b;
//}
//float Add_float(float a, float b)
//{
//	return a + b;
//}
//int main(void)
//{
//	printf("%d\n", Add_int(1, 2));
//	printf("%.2f\n", Add_float(1.111, 2.222));
//}



//19. �Ű������� �迭�� �޾� �������� ���� �迭�� ��ȯ�ϴ� �Լ���
//	���������� ���� �迭�� ��ȯ�ϴ� �Լ� 2�� �����

const int length = 10;

int Arr_right(int arr[length])
{

		int temp = arr[length-1]; //�迭 ����

		for (int j = length-1; j > 0; j--) //���������� �б�
		{
			arr[j] = arr[j - 1];
		}
		arr[0] = temp; //������ �� �ֱ�
		return arr[length];

}

int Arr_left(int arr[length])
{

	int temp = arr[0]; //�迭 ����

	for (int j = 0; j < length; j++) //�������� �б�
	{
		arr[j] = arr[j + 1];
	}
	arr[length - 1] = temp;//������ �� �ֱ�
	return arr[length];

}

int main(void)
{
	int arr[length];
	for (int i = 0; i < length; i++) //�ʱ�ȭ
	{
		arr[i] = i;
	}


	Arr_right(arr);//������
	for (int i = 0; i < length; i++)
	{
		printf("%2d", arr[i]);
	}
	printf("\n");


	for (int i = 0; i < length; i++)//�ʱ�ȭ
	{
		arr[i] = i;
	}

	Arr_left(arr);//����
	for (int i = 0; i < length; i++)
	{
		printf("%2d", arr[i]);
	}

}